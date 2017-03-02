using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunSqlScript
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        BackgroundWorker connectionTester;
        BackgroundWorker lineByLineWorker;

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateConnectionString(sender, e);
        }

        private void UpdateConnectionString(object sender, EventArgs e)
        {
            builder.Clear();
            builder.DataSource = enteredDatabaseAddress.Text;
            builder.InitialCatalog = enteredDatabaseName.Text;
            builder.UserID = enteredLogin.Text;
            builder.Password = enteredPassword.Text;
            labelConnectionString.Text = builder.ToString();
        }

        private void testConnectionClick(object sender, EventArgs e)
        {
            if (connectionTester == null)
            {
                connectionTester = new BackgroundWorker();
                connectionTester.DoWork += ConnectionTester_DoWork;
                connectionTester.RunWorkerCompleted += ConnectionTester_RunWorkerCompleted;
            }
            if (!connectionTester.IsBusy)
            {
                groupBoxConnection.Enabled = false;
                connectionTester.RunWorkerAsync(builder.ToString());
            }
        }

        private void ConnectionTester_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var result = (string)e.Result;
            if (result == string.Empty)
            {
                MessageBox.Show("Połączenie zostało nawiązane.");
            }
            else
            {
                MessageBox.Show("Nie można nawiązać połączenia.");
            }
            groupBoxConnection.Enabled = true;
        }

        private void ConnectionTester_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string cs = (string)e.Argument;

                var connection = SqlClientFactory.Instance.CreateConnection();
                connection.ConnectionString = cs;

                connection.Open();
                connection.Close();

                e.Result = string.Empty;
            }
            catch (Exception ex)
            {
                e.Result = ex.Message; ;
            }
        }

        private void ChooseSqlFile(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.CheckFileExists = true;
            dialog.Filter = "SQL|*.sql|TXT|*.txt|*.*|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sqlFile.Text = dialog.FileName;
            }
        }

        private void LineByLineClick(object sender, EventArgs e)
        {
            if (lineByLineWorker == null)
            {
                lineByLineWorker = new BackgroundWorker();
                lineByLineWorker.RunWorkerCompleted += LineByLineWorker_RunWorkerCompleted;
                lineByLineWorker.ProgressChanged += LineByLineWorker_ProgressChanged;
                lineByLineWorker.DoWork += LineByLineWorker_DoWork;
                lineByLineWorker.WorkerSupportsCancellation = true;
                lineByLineWorker.WorkerReportsProgress = true;
            }
            if (!lineByLineWorker.IsBusy)
            {
                ((Button)sender).Tag = ((Button)sender).Text;
                ((Button)sender).Text = "Anuluj";
                lineByLineWorker.RunWorkerAsync(new string[] { sqlFile.Text, builder.ToString() });
            }
            else
            {
                ((Button)sender).Text = (string)((Button)sender).Tag;
                lineByLineWorker.CancelAsync();
            }
        }

        private void LineByLineWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] args = e.Argument as string[];
            string file = args[0];
            string connectionString = args[1];
            try
            {
                using (var tr = new StreamReader(file))
                {
                    int counter = 0;
                    string line;
                    while ((line = tr.ReadLine()) != null) counter++;
                    (sender as BackgroundWorker).ReportProgress(-counter);
                }
                var connection = SqlClientFactory.Instance.CreateConnection();
                connection.ConnectionString = connectionString;                
                connection.Open();
                var tran = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                int numberOfNotExecuted = 0;
                using (var tr = new StreamReader(file))
                {
                    int counter = 0;
                    string line;

                    while ((line = tr.ReadLine()) != null)
                    {
                        if ((sender as BackgroundWorker).CancellationPending) break;

                        try
                        {
                            if (line != "GO")
                            {
                                var command = connection.CreateCommand();
                                command.CommandText = line;
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception sqlEx)
                        {
                            numberOfNotExecuted++;                            
                        }
                        counter++;
                        (sender as BackgroundWorker).ReportProgress(counter);
                    }
                }
                if (numberOfNotExecuted == 0)
                {
                    tran.Commit();
                }else
                {
                    tran.Rollback();
                }
                connection.Close();
                e.Result = numberOfNotExecuted;
            }
            catch
            {
                e.Result = -1;
            }
        }

        private void LineByLineWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage < 0)
            {
                progress.Minimum = 0;
                progress.Maximum = -e.ProgressPercentage;
            }
            else
            {
                progress.Value = e.ProgressPercentage;
            }
        }

        private void LineByLineWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonExecuteLineByLine.Text = (string)(buttonExecuteLineByLine.Tag);
            if (e.Cancelled)
            {

            }
            int numberOfNotExecuted = (int)e.Result;
            if (numberOfNotExecuted == 0)
            {

            }
            else
            {
                MessageBox.Show(string.Format("Błąd podczas wykonywania kodu SQL. Nie wykonano: {0} linii kodu.", numberOfNotExecuted));
            }
        }
    }
}
