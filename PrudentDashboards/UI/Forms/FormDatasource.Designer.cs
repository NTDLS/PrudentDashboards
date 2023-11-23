namespace UI.Forms
{
    partial class FormDatasource
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatasource));
            buttonCancel = new Button();
            buttonOk = new Button();
            textBoxUsername = new TextBox();
            label3 = new Label();
            checkBoxIntegratedSecurity = new CheckBox();
            textBoxPassword = new TextBox();
            textBoxServerName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBoxSQLServerConnectivity = new GroupBox();
            checkBoxSSLConnection = new CheckBox();
            label4 = new Label();
            textBoxDatabaseName = new TextBox();
            GroupBoxLine = new GroupBox();
            pictureBox1 = new PictureBox();
            textBoxName = new TextBox();
            labelName = new Label();
            labelDescription = new Label();
            textBoxDescription = new TextBox();
            groupBoxIdentification = new GroupBox();
            groupBoxSQLServerConnectivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxIdentification.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(534, 330);
            buttonCancel.Margin = new Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(88, 27);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(438, 330);
            buttonOk.Margin = new Padding(4, 3, 4, 3);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(88, 27);
            buttonOk.TabIndex = 10;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += ButtonOk_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Enabled = false;
            textBoxUsername.Location = new Point(10, 102);
            textBoxUsername.Margin = new Padding(4, 3, 4, 3);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(223, 23);
            textBoxUsername.TabIndex = 5;
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
            // checkBoxIntegratedSecurity
            // 
            checkBoxIntegratedSecurity.Checked = true;
            checkBoxIntegratedSecurity.CheckState = CheckState.Checked;
            checkBoxIntegratedSecurity.Location = new Point(10, 177);
            checkBoxIntegratedSecurity.Margin = new Padding(4, 3, 4, 3);
            checkBoxIntegratedSecurity.Name = "checkBoxIntegratedSecurity";
            checkBoxIntegratedSecurity.Size = new Size(166, 21);
            checkBoxIntegratedSecurity.TabIndex = 7;
            checkBoxIntegratedSecurity.Text = "Use Integrated Security?";
            checkBoxIntegratedSecurity.CheckedChanged += CheckboxIntegratedSecurity_CheckedChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Enabled = false;
            textBoxPassword.Location = new Point(10, 147);
            textBoxPassword.Margin = new Padding(4, 3, 4, 3);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(223, 23);
            textBoxPassword.TabIndex = 6;
            // 
            // textBoxServerName
            // 
            textBoxServerName.Location = new Point(10, 46);
            textBoxServerName.Margin = new Padding(4, 3, 4, 3);
            textBoxServerName.Name = "textBoxServerName";
            textBoxServerName.Size = new Size(223, 23);
            textBoxServerName.TabIndex = 4;
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
            // groupBoxSQLServerConnectivity
            // 
            groupBoxSQLServerConnectivity.AccessibleRole = AccessibleRole.Grouping;
            groupBoxSQLServerConnectivity.Controls.Add(checkBoxSSLConnection);
            groupBoxSQLServerConnectivity.Controls.Add(label4);
            groupBoxSQLServerConnectivity.Controls.Add(textBoxDatabaseName);
            groupBoxSQLServerConnectivity.Controls.Add(GroupBoxLine);
            groupBoxSQLServerConnectivity.Controls.Add(textBoxUsername);
            groupBoxSQLServerConnectivity.Controls.Add(label3);
            groupBoxSQLServerConnectivity.Controls.Add(checkBoxIntegratedSecurity);
            groupBoxSQLServerConnectivity.Controls.Add(textBoxPassword);
            groupBoxSQLServerConnectivity.Controls.Add(textBoxServerName);
            groupBoxSQLServerConnectivity.Controls.Add(label1);
            groupBoxSQLServerConnectivity.Controls.Add(label2);
            groupBoxSQLServerConnectivity.Location = new Point(371, 12);
            groupBoxSQLServerConnectivity.Margin = new Padding(4, 3, 4, 3);
            groupBoxSQLServerConnectivity.Name = "groupBoxSQLServerConnectivity";
            groupBoxSQLServerConnectivity.Padding = new Padding(4, 3, 4, 3);
            groupBoxSQLServerConnectivity.Size = new Size(251, 306);
            groupBoxSQLServerConnectivity.TabIndex = 3;
            groupBoxSQLServerConnectivity.TabStop = false;
            groupBoxSQLServerConnectivity.Text = "SQL Server Connectivity";
            // 
            // checkBoxSSLConnection
            // 
            checkBoxSSLConnection.Location = new Point(10, 203);
            checkBoxSSLConnection.Margin = new Padding(4, 3, 4, 3);
            checkBoxSSLConnection.Name = "checkBoxSSLConnection";
            checkBoxSSLConnection.Size = new Size(178, 21);
            checkBoxSSLConnection.TabIndex = 8;
            checkBoxSSLConnection.Text = "Encrypt Connection (SSL) ?";
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
            // textBoxDatabaseName
            // 
            textBoxDatabaseName.Location = new Point(10, 271);
            textBoxDatabaseName.Margin = new Padding(4, 3, 4, 3);
            textBoxDatabaseName.Name = "textBoxDatabaseName";
            textBoxDatabaseName.Size = new Size(224, 23);
            textBoxDatabaseName.TabIndex = 9;
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
            // textBoxName
            // 
            textBoxName.Location = new Point(10, 41);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(261, 23);
            textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(10, 23);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 9;
            labelName.Text = "Name";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(10, 73);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(67, 15);
            labelDescription.TabIndex = 10;
            labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(10, 95);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(261, 193);
            textBoxDescription.TabIndex = 2;
            // 
            // groupBoxIdentification
            // 
            groupBoxIdentification.Controls.Add(labelName);
            groupBoxIdentification.Controls.Add(textBoxDescription);
            groupBoxIdentification.Controls.Add(textBoxName);
            groupBoxIdentification.Controls.Add(labelDescription);
            groupBoxIdentification.Location = new Point(81, 12);
            groupBoxIdentification.Name = "groupBoxIdentification";
            groupBoxIdentification.Size = new Size(283, 306);
            groupBoxIdentification.TabIndex = 0;
            groupBoxIdentification.TabStop = false;
            groupBoxIdentification.Text = "Identification";
            // 
            // FormEstablishSQLServerDatasourceConnection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 368);
            Controls.Add(groupBoxIdentification);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(groupBoxSQLServerConnectivity);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEstablishSQLServerDatasourceConnection";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Establish SQLServer Connection";
            Load += EstablishSQLServerConnection_Load;
            groupBoxSQLServerConnectivity.ResumeLayout(false);
            groupBoxSQLServerConnectivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxIdentification.ResumeLayout(false);
            groupBoxIdentification.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCancel;
        private Button buttonOk;
        private TextBox textBoxUsername;
        private Label label3;
        private CheckBox checkBoxIntegratedSecurity;
        private TextBox textBoxPassword;
        private TextBox textBoxServerName;
        private Label label1;
        private Label label2;
        private GroupBox groupBoxSQLServerConnectivity;
        private CheckBox checkBoxSSLConnection;
        private Label label4;
        private TextBox textBoxDatabaseName;
        private GroupBox GroupBoxLine;
        private PictureBox pictureBox1;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelDescription;
        private TextBox textBoxDescription;
        private GroupBox groupBoxIdentification;
    }
}