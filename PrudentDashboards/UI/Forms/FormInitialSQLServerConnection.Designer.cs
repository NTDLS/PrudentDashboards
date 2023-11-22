﻿namespace PrudentDashboards.UI
{
    partial class FormInitialSQLServerConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInitialSQLServerConnection));
            cmdOk = new Button();
            cmdCancel = new Button();
            cbIntegratedSecurity = new CheckBox();
            cboServerName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            cbSSLConnection = new CheckBox();
            label4 = new Label();
            cboDatabaseName = new TextBox();
            GroupBoxLine = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmdOk
            // 
            cmdOk.Location = new Point(150, 332);
            cmdOk.Margin = new Padding(4, 3, 4, 3);
            cmdOk.Name = "cmdOk";
            cmdOk.Size = new Size(88, 27);
            cmdOk.TabIndex = 1;
            cmdOk.Text = "Ok";
            cmdOk.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            cmdCancel.Location = new Point(245, 332);
            cmdCancel.Margin = new Padding(4, 3, 4, 3);
            cmdCancel.Name = "cmdCancel";
            cmdCancel.Size = new Size(88, 27);
            cmdCancel.TabIndex = 2;
            cmdCancel.Text = "Cancel";
            cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cbIntegratedSecurity
            // 
            cbIntegratedSecurity.Checked = true;
            cbIntegratedSecurity.CheckState = CheckState.Checked;
            cbIntegratedSecurity.Location = new Point(10, 177);
            cbIntegratedSecurity.Margin = new Padding(4, 3, 4, 3);
            cbIntegratedSecurity.Name = "cbIntegratedSecurity";
            cbIntegratedSecurity.Size = new Size(166, 21);
            cbIntegratedSecurity.TabIndex = 6;
            cbIntegratedSecurity.Text = "Use Integrated Security?";
            // 
            // cboServerName
            // 
            cboServerName.Location = new Point(10, 46);
            cboServerName.Margin = new Padding(4, 3, 4, 3);
            cboServerName.Name = "cboServerName";
            cboServerName.Size = new Size(223, 23);
            cboServerName.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(7, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.Location = new Point(7, 127);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Enabled = false;
            txtUsername.Location = new Point(10, 102);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(223, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(10, 147);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(223, 23);
            txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.Location = new Point(7, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 0;
            label3.Text = "Server Name:";
            // 
            // groupBox1
            // 
            groupBox1.AccessibleRole = AccessibleRole.Grouping;
            groupBox1.Controls.Add(cbSSLConnection);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboDatabaseName);
            groupBox1.Controls.Add(GroupBoxLine);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbIntegratedSecurity);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(cboServerName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(82, 15);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(251, 306);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "SQL Server Connectivity Attributes";
            // 
            // cbSSLConnection
            // 
            cbSSLConnection.Location = new Point(10, 203);
            cbSSLConnection.Margin = new Padding(4, 3, 4, 3);
            cbSSLConnection.Name = "cbSSLConnection";
            cbSSLConnection.Size = new Size(178, 21);
            cbSSLConnection.TabIndex = 10;
            cbSSLConnection.Text = "Encrypt Connection (SSL) ?";
            // 
            // label4
            // 
            label4.Location = new Point(7, 250);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 8;
            label4.Text = "Database Name:";
            // 
            // cboDatabaseName
            // 
            cboDatabaseName.Location = new Point(10, 271);
            cboDatabaseName.Margin = new Padding(4, 3, 4, 3);
            cboDatabaseName.Name = "cboDatabaseName";
            cboDatabaseName.Size = new Size(224, 23);
            cboDatabaseName.TabIndex = 9;
            // 
            // GroupBoxLine
            // 
            GroupBoxLine.AccessibleRole = AccessibleRole.Grouping;
            GroupBoxLine.Location = new Point(10, 233);
            GroupBoxLine.Margin = new Padding(4, 3, 4, 3);
            GroupBoxLine.Name = "GroupBoxLine";
            GroupBoxLine.Padding = new Padding(4, 3, 4, 3);
            GroupBoxLine.Size = new Size(224, 2);
            GroupBoxLine.TabIndex = 7;
            GroupBoxLine.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 42);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 65);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormInitialSQLServerConnection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 369);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(cmdCancel);
            Controls.Add(cmdOk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInitialSQLServerConnection";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Connect to SQL Server";
            Load += SQLConnectForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.CheckBox cbIntegratedSecurity;
        private System.Windows.Forms.TextBox cboServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cboDatabaseName;
        private System.Windows.Forms.GroupBox GroupBoxLine;
        private System.Windows.Forms.CheckBox cbSSLConnection;
    }
}