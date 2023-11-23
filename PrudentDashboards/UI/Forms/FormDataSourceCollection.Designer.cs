namespace UI.Forms
{
    partial class FormDataSourceCollection
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
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            listViewDataSources = new ListView();
            columnHeaderName = new ColumnHeader();
            buttonClose = new Button();
            columnHeaderServer = new ColumnHeader();
            columnHeaderDatabase = new ColumnHeader();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(658, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(658, 41);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += ButtonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(658, 88);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // listViewDataSources
            // 
            listViewDataSources.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderServer, columnHeaderDatabase });
            listViewDataSources.FullRowSelect = true;
            listViewDataSources.GridLines = true;
            listViewDataSources.Location = new Point(12, 12);
            listViewDataSources.Name = "listViewDataSources";
            listViewDataSources.Size = new Size(640, 452);
            listViewDataSources.TabIndex = 3;
            listViewDataSources.UseCompatibleStateImageBehavior = false;
            listViewDataSources.View = View.Details;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 200;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(658, 441);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // columnHeaderServer
            // 
            columnHeaderServer.Text = "Server";
            columnHeaderServer.Width = 200;
            // 
            // columnHeaderDatabase
            // 
            columnHeaderDatabase.Text = "Database";
            columnHeaderDatabase.Width = 200;
            // 
            // FormDataSources
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 485);
            Controls.Add(buttonClose);
            Controls.Add(listViewDataSources);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDataSources";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Data Sources";
            Load += FormDataSources_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private ListView listViewDataSources;
        private ColumnHeader columnHeaderName;
        private Button buttonClose;
        private ColumnHeader columnHeaderServer;
        private ColumnHeader columnHeaderDatabase;
    }
}