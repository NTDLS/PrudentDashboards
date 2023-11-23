namespace UI.Forms
{
    partial class FormEstablishSQLServerConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstablishSQLServerConnection));
            buttonCancel = new Button();
            buttonOk = new Button();
            textboxUsername = new TextBox();
            label3 = new Label();
            checkboxIntegratedSecurity = new CheckBox();
            textboxPassword = new TextBox();
            textboxServerName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            checkboxSSLConnection = new CheckBox();
            label4 = new Label();
            textboxDatabaseName = new TextBox();
            GroupBoxLine = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(244, 329);
            buttonCancel.Margin = new Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(88, 27);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(149, 329);
            buttonOk.Margin = new Padding(4, 3, 4, 3);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(88, 27);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += ButtonOk_Click;
            // 
            // textboxUsername
            // 
            textboxUsername.Enabled = false;
            textboxUsername.Location = new Point(10, 102);
            textboxUsername.Margin = new Padding(4, 3, 4, 3);
            textboxUsername.Name = "textboxUsername";
            textboxUsername.Size = new Size(223, 23);
            textboxUsername.TabIndex = 3;
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
            // checkboxIntegratedSecurity
            // 
            checkboxIntegratedSecurity.Checked = true;
            checkboxIntegratedSecurity.CheckState = CheckState.Checked;
            checkboxIntegratedSecurity.Location = new Point(10, 177);
            checkboxIntegratedSecurity.Margin = new Padding(4, 3, 4, 3);
            checkboxIntegratedSecurity.Name = "checkboxIntegratedSecurity";
            checkboxIntegratedSecurity.Size = new Size(166, 21);
            checkboxIntegratedSecurity.TabIndex = 6;
            checkboxIntegratedSecurity.Text = "Use Integrated Security?";
            checkboxIntegratedSecurity.CheckedChanged += CheckboxIntegratedSecurity_CheckedChanged;
            // 
            // textboxPassword
            // 
            textboxPassword.Enabled = false;
            textboxPassword.Location = new Point(10, 147);
            textboxPassword.Margin = new Padding(4, 3, 4, 3);
            textboxPassword.Name = "textboxPassword";
            textboxPassword.PasswordChar = '*';
            textboxPassword.Size = new Size(223, 23);
            textboxPassword.TabIndex = 5;
            // 
            // textboxServerName
            // 
            textboxServerName.Location = new Point(10, 46);
            textboxServerName.Margin = new Padding(4, 3, 4, 3);
            textboxServerName.Name = "textboxServerName";
            textboxServerName.Size = new Size(223, 23);
            textboxServerName.TabIndex = 1;
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
            // groupBox1
            // 
            groupBox1.AccessibleRole = AccessibleRole.Grouping;
            groupBox1.Controls.Add(checkboxSSLConnection);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textboxDatabaseName);
            groupBox1.Controls.Add(GroupBoxLine);
            groupBox1.Controls.Add(textboxUsername);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkboxIntegratedSecurity);
            groupBox1.Controls.Add(textboxPassword);
            groupBox1.Controls.Add(textboxServerName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(81, 12);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(251, 306);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "SQL Server Connectivity Attributes";
            // 
            // checkboxSSLConnection
            // 
            checkboxSSLConnection.Location = new Point(10, 203);
            checkboxSSLConnection.Margin = new Padding(4, 3, 4, 3);
            checkboxSSLConnection.Name = "checkboxSSLConnection";
            checkboxSSLConnection.Size = new Size(178, 21);
            checkboxSSLConnection.TabIndex = 10;
            checkboxSSLConnection.Text = "Encrypt Connection (SSL) ?";
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
            // textboxDatabaseName
            // 
            textboxDatabaseName.Location = new Point(10, 271);
            textboxDatabaseName.Margin = new Padding(4, 3, 4, 3);
            textboxDatabaseName.Name = "textboxDatabaseName";
            textboxDatabaseName.Size = new Size(224, 23);
            textboxDatabaseName.TabIndex = 9;
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
            pictureBox1.Location = new Point(13, 39);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 65);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FormEstablishSQLServerConnection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 376);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEstablishSQLServerConnection";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Establish SQLServer Connection";
            Load += EstablishSQLServerConnection_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCancel;
        private Button buttonOk;
        private TextBox textboxUsername;
        private Label label3;
        private CheckBox checkboxIntegratedSecurity;
        private TextBox textboxPassword;
        private TextBox textboxServerName;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private CheckBox checkboxSSLConnection;
        private Label label4;
        private TextBox textboxDatabaseName;
        private GroupBox GroupBoxLine;
        private PictureBox pictureBox1;
    }
}