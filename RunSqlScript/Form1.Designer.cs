namespace RunSqlScript
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.labelConnectionString = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.enteredPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.enteredLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enteredDatabaseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enteredDatabaseAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sqlFile = new System.Windows.Forms.TextBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.buttonExecuteLineByLine = new System.Windows.Forms.Button();
            this.groupBoxConnection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.Controls.Add(this.buttonTestConnection);
            this.groupBoxConnection.Controls.Add(this.labelConnectionString);
            this.groupBoxConnection.Controls.Add(this.label5);
            this.groupBoxConnection.Controls.Add(this.enteredPassword);
            this.groupBoxConnection.Controls.Add(this.label4);
            this.groupBoxConnection.Controls.Add(this.enteredLogin);
            this.groupBoxConnection.Controls.Add(this.label3);
            this.groupBoxConnection.Controls.Add(this.enteredDatabaseName);
            this.groupBoxConnection.Controls.Add(this.label2);
            this.groupBoxConnection.Controls.Add(this.enteredDatabaseAddress);
            this.groupBoxConnection.Controls.Add(this.label1);
            this.groupBoxConnection.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Size = new System.Drawing.Size(622, 266);
            this.groupBoxConnection.TabIndex = 0;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "Połączenie";
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.Location = new System.Drawing.Point(549, 205);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(67, 55);
            this.buttonTestConnection.TabIndex = 10;
            this.buttonTestConnection.Text = "Test";
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Click += new System.EventHandler(this.testConnectionClick);
            // 
            // labelConnectionString
            // 
            this.labelConnectionString.Location = new System.Drawing.Point(107, 25);
            this.labelConnectionString.Name = "labelConnectionString";
            this.labelConnectionString.Size = new System.Drawing.Size(509, 40);
            this.labelConnectionString.TabIndex = 9;
            this.labelConnectionString.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ciąg połączenia:";
            // 
            // enteredPassword
            // 
            this.enteredPassword.Location = new System.Drawing.Point(16, 237);
            this.enteredPassword.Name = "enteredPassword";
            this.enteredPassword.Size = new System.Drawing.Size(353, 20);
            this.enteredPassword.TabIndex = 7;
            this.enteredPassword.Text = "sa";
            this.enteredPassword.TextChanged += new System.EventHandler(this.UpdateConnectionString);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasło";
            // 
            // enteredLogin
            // 
            this.enteredLogin.Location = new System.Drawing.Point(16, 186);
            this.enteredLogin.Name = "enteredLogin";
            this.enteredLogin.Size = new System.Drawing.Size(353, 20);
            this.enteredLogin.TabIndex = 5;
            this.enteredLogin.Text = "sa";
            this.enteredLogin.TextChanged += new System.EventHandler(this.UpdateConnectionString);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login";
            // 
            // enteredDatabaseName
            // 
            this.enteredDatabaseName.Location = new System.Drawing.Point(16, 137);
            this.enteredDatabaseName.Name = "enteredDatabaseName";
            this.enteredDatabaseName.Size = new System.Drawing.Size(353, 20);
            this.enteredDatabaseName.TabIndex = 3;
            this.enteredDatabaseName.Text = "Testowa";
            this.enteredDatabaseName.TextChanged += new System.EventHandler(this.UpdateConnectionString);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwa bazy";
            // 
            // enteredDatabaseAddress
            // 
            this.enteredDatabaseAddress.Location = new System.Drawing.Point(16, 88);
            this.enteredDatabaseAddress.Name = "enteredDatabaseAddress";
            this.enteredDatabaseAddress.Size = new System.Drawing.Size(353, 20);
            this.enteredDatabaseAddress.TabIndex = 1;
            this.enteredDatabaseAddress.Text = "MAREKBAR\\SQLEXPRESS2016";
            this.enteredDatabaseAddress.TextChanged += new System.EventHandler(this.UpdateConnectionString);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adres bazy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sqlFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 93);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plik SQL";
            // 
            // sqlFile
            // 
            this.sqlFile.Location = new System.Drawing.Point(7, 20);
            this.sqlFile.Multiline = true;
            this.sqlFile.Name = "sqlFile";
            this.sqlFile.Size = new System.Drawing.Size(609, 67);
            this.sqlFile.TabIndex = 0;
            this.sqlFile.Click += new System.EventHandler(this.ChooseSqlFile);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 383);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(622, 23);
            this.progress.TabIndex = 2;
            // 
            // buttonExecuteLineByLine
            // 
            this.buttonExecuteLineByLine.Location = new System.Drawing.Point(12, 412);
            this.buttonExecuteLineByLine.Name = "buttonExecuteLineByLine";
            this.buttonExecuteLineByLine.Size = new System.Drawing.Size(622, 23);
            this.buttonExecuteLineByLine.TabIndex = 3;
            this.buttonExecuteLineByLine.Text = "Wykonaj linia po linii";
            this.buttonExecuteLineByLine.UseVisualStyleBackColor = true;
            this.buttonExecuteLineByLine.Click += new System.EventHandler(this.LineByLineClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 454);
            this.Controls.Add(this.buttonExecuteLineByLine);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxConnection);
            this.MaximumSize = new System.Drawing.Size(659, 493);
            this.MinimumSize = new System.Drawing.Size(659, 493);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uruchamianie dużych skryptów SQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxConnection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.TextBox enteredPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox enteredLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox enteredDatabaseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enteredDatabaseAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelConnectionString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTestConnection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox sqlFile;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button buttonExecuteLineByLine;
    }
}

