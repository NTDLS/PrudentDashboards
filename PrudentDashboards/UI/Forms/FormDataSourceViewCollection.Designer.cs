namespace UI.Forms
{
    partial class FormDataSourceViewCollection
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
            listViewDataViews = new ListView();
            columnHeaderName = new ColumnHeader();
            buttonClose = new Button();
            columnHeaderDataSource = new ColumnHeader();
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
            listViewDataViews.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderDataSource });
            listViewDataViews.FullRowSelect = true;
            listViewDataViews.GridLines = true;
            listViewDataViews.Location = new Point(12, 12);
            listViewDataViews.Name = "listViewDataSources";
            listViewDataViews.Size = new Size(640, 452);
            listViewDataViews.TabIndex = 3;
            listViewDataViews.UseCompatibleStateImageBehavior = false;
            listViewDataViews.View = View.Details;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 300;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(658, 441);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += ButtonClose_Click;
            // 
            // columnHeaderDataSource
            // 
            columnHeaderDataSource.Text = "Data Source";
            columnHeaderDataSource.Width = 200;
            // 
            // FormDataViews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 485);
            Controls.Add(buttonClose);
            Controls.Add(listViewDataViews);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDataViews";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Data Views";
            Load += FormDataViews_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private ListView listViewDataViews;
        private ColumnHeader columnHeaderName;
        private Button buttonClose;
        private ColumnHeader columnHeaderDataSource;
    }
}