namespace AMTANGEE.Tools.EmailAssignment
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnDoAssignment = new System.Windows.Forms.Button();
            this.pbMain = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edtSQLServer = new System.Windows.Forms.TextBox();
            this.edtSQLUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtSQLPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkUseIntegratedSecurity = new System.Windows.Forms.CheckBox();
            this.edtSQLDatabase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDoAssignment
            // 
            this.btnDoAssignment.Location = new System.Drawing.Point(343, 241);
            this.btnDoAssignment.Name = "btnDoAssignment";
            this.btnDoAssignment.Size = new System.Drawing.Size(83, 23);
            this.btnDoAssignment.TabIndex = 3;
            this.btnDoAssignment.Text = "Durchführen";
            this.btnDoAssignment.UseVisualStyleBackColor = true;
            this.btnDoAssignment.Click += new System.EventHandler(this.btnDoAssignment_Click);
            // 
            // pbMain
            // 
            this.pbMain.Location = new System.Drawing.Point(19, 189);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(407, 23);
            this.pbMain.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 279);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(442, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 13);
            this.label5.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 19);
            this.label2.TabIndex = 7;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "SQL-Server";
            // 
            // edtSQLServer
            // 
            this.edtSQLServer.Location = new System.Drawing.Point(19, 31);
            this.edtSQLServer.Name = "edtSQLServer";
            this.edtSQLServer.Size = new System.Drawing.Size(234, 20);
            this.edtSQLServer.TabIndex = 11;
            // 
            // edtSQLUser
            // 
            this.edtSQLUser.Location = new System.Drawing.Point(19, 78);
            this.edtSQLUser.Name = "edtSQLUser";
            this.edtSQLUser.Size = new System.Drawing.Size(114, 20);
            this.edtSQLUser.TabIndex = 13;
            this.edtSQLUser.Text = "sa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Benutzer";
            // 
            // edtSQLPassword
            // 
            this.edtSQLPassword.Location = new System.Drawing.Point(139, 78);
            this.edtSQLPassword.Name = "edtSQLPassword";
            this.edtSQLPassword.PasswordChar = '*';
            this.edtSQLPassword.Size = new System.Drawing.Size(114, 20);
            this.edtSQLPassword.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Passwort";
            // 
            // chkUseIntegratedSecurity
            // 
            this.chkUseIntegratedSecurity.AutoSize = true;
            this.chkUseIntegratedSecurity.Location = new System.Drawing.Point(19, 105);
            this.chkUseIntegratedSecurity.Name = "chkUseIntegratedSecurity";
            this.chkUseIntegratedSecurity.Size = new System.Drawing.Size(126, 17);
            this.chkUseIntegratedSecurity.TabIndex = 16;
            this.chkUseIntegratedSecurity.Text = "Windows-Anmeldung";
            this.chkUseIntegratedSecurity.UseVisualStyleBackColor = true;
            this.chkUseIntegratedSecurity.CheckedChanged += new System.EventHandler(this.chkUseIntegratedSecurity_CheckedChanged);
            // 
            // edtSQLDatabase
            // 
            this.edtSQLDatabase.Location = new System.Drawing.Point(19, 145);
            this.edtSQLDatabase.Name = "edtSQLDatabase";
            this.edtSQLDatabase.Size = new System.Drawing.Size(234, 20);
            this.edtSQLDatabase.TabIndex = 18;
            this.edtSQLDatabase.Text = "AMTANGEE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Datenbankname";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 301);
            this.Controls.Add(this.edtSQLDatabase);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkUseIntegratedSecurity);
            this.Controls.Add(this.edtSQLPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edtSQLUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edtSQLServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.btnDoAssignment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zuordnungstool für Emails";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoAssignment;
        private System.Windows.Forms.ProgressBar pbMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtSQLServer;
        private System.Windows.Forms.TextBox edtSQLUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtSQLPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkUseIntegratedSecurity;
        private System.Windows.Forms.TextBox edtSQLDatabase;
        private System.Windows.Forms.Label label7;
    }
}

