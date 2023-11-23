namespace UI
{
    partial class FormDataSourceView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataSourceView));
            splitContainerHoriz = new SplitContainer();
            dataGridViewResults = new DataGridView();
            splitContainerVert = new SplitContainer();
            panel1 = new Panel();
            comboBoxDatasource = new ComboBox();
            labelDatasource = new Label();
            labelDescription = new Label();
            labelName = new Label();
            textBoxDescription = new TextBox();
            textBoxName = new TextBox();
            listViewFields = new ListView();
            columnHeaderAlias = new ColumnHeader();
            columnHeaderName = new ColumnHeader();
            columnHeaderType = new ColumnHeader();
            toolStripHeader = new ToolStrip();
            toolStripButtonSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonRun = new ToolStripButton();
            toolStripButtonStop = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            ((System.ComponentModel.ISupportInitialize)splitContainerHoriz).BeginInit();
            splitContainerHoriz.Panel2.SuspendLayout();
            splitContainerHoriz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerVert).BeginInit();
            splitContainerVert.Panel1.SuspendLayout();
            splitContainerVert.Panel2.SuspendLayout();
            splitContainerVert.SuspendLayout();
            panel1.SuspendLayout();
            toolStripHeader.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainerHoriz
            // 
            splitContainerHoriz.Dock = DockStyle.Fill;
            splitContainerHoriz.Location = new Point(0, 113);
            splitContainerHoriz.Name = "splitContainerHoriz";
            splitContainerHoriz.Orientation = Orientation.Horizontal;
            // 
            // splitContainerHoriz.Panel1
            // 
            splitContainerHoriz.Panel1.Padding = new Padding(5);
            // 
            // splitContainerHoriz.Panel2
            // 
            splitContainerHoriz.Panel2.Controls.Add(dataGridViewResults);
            splitContainerHoriz.Size = new Size(650, 461);
            splitContainerHoriz.SplitterDistance = 289;
            splitContainerHoriz.TabIndex = 1;
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.BackgroundColor = SystemColors.Control;
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Dock = DockStyle.Fill;
            dataGridViewResults.GridColor = SystemColors.Control;
            dataGridViewResults.Location = new Point(0, 0);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.Size = new Size(650, 168);
            dataGridViewResults.TabIndex = 1;
            // 
            // splitContainerVert
            // 
            splitContainerVert.Dock = DockStyle.Fill;
            splitContainerVert.FixedPanel = FixedPanel.Panel2;
            splitContainerVert.Location = new Point(0, 25);
            splitContainerVert.Name = "splitContainerVert";
            // 
            // splitContainerVert.Panel1
            // 
            splitContainerVert.Panel1.Controls.Add(splitContainerHoriz);
            splitContainerVert.Panel1.Controls.Add(panel1);
            splitContainerVert.Panel1MinSize = 650;
            // 
            // splitContainerVert.Panel2
            // 
            splitContainerVert.Panel2.Controls.Add(listViewFields);
            splitContainerVert.Panel2.Padding = new Padding(2);
            splitContainerVert.Size = new Size(1027, 574);
            splitContainerVert.SplitterDistance = 650;
            splitContainerVert.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxDatasource);
            panel1.Controls.Add(labelDatasource);
            panel1.Controls.Add(labelDescription);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(textBoxDescription);
            panel1.Controls.Add(textBoxName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 113);
            panel1.TabIndex = 2;
            // 
            // comboBoxDatasource
            // 
            comboBoxDatasource.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDatasource.FormattingEnabled = true;
            comboBoxDatasource.Location = new Point(88, 11);
            comboBoxDatasource.Name = "comboBoxDatasource";
            comboBoxDatasource.Size = new Size(537, 23);
            comboBoxDatasource.TabIndex = 5;
            // 
            // labelDatasource
            // 
            labelDatasource.AutoSize = true;
            labelDatasource.Location = new Point(12, 14);
            labelDatasource.Name = "labelDatasource";
            labelDatasource.Size = new Size(70, 15);
            labelDatasource.TabIndex = 4;
            labelDatasource.Text = "Data Source";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(15, 72);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(67, 15);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Description";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(42, 43);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 2;
            labelName.Text = "Name";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(87, 69);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(538, 23);
            textBoxDescription.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(87, 40);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(538, 23);
            textBoxName.TabIndex = 0;
            // 
            // listViewFields
            // 
            listViewFields.CheckBoxes = true;
            listViewFields.Columns.AddRange(new ColumnHeader[] { columnHeaderAlias, columnHeaderName, columnHeaderType });
            listViewFields.Dock = DockStyle.Fill;
            listViewFields.FullRowSelect = true;
            listViewFields.GridLines = true;
            listViewFields.LabelEdit = true;
            listViewFields.Location = new Point(2, 2);
            listViewFields.Name = "listViewFields";
            listViewFields.Size = new Size(369, 570);
            listViewFields.TabIndex = 1;
            listViewFields.UseCompatibleStateImageBehavior = false;
            listViewFields.View = View.Details;
            // 
            // columnHeaderAlias
            // 
            columnHeaderAlias.Text = "Alias";
            columnHeaderAlias.Width = 125;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 125;
            // 
            // columnHeaderType
            // 
            columnHeaderType.Text = "Type";
            columnHeaderType.Width = 100;
            // 
            // toolStripHeader
            // 
            toolStripHeader.Items.AddRange(new ToolStripItem[] { toolStripButtonSave, toolStripSeparator1, toolStripButtonRun, toolStripButtonStop });
            toolStripHeader.Location = new Point(0, 0);
            toolStripHeader.Name = "toolStripHeader";
            toolStripHeader.Size = new Size(1027, 25);
            toolStripHeader.TabIndex = 3;
            toolStripHeader.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSave.Image = (Image)resources.GetObject("toolStripButtonSave.Image");
            toolStripButtonSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new Size(23, 22);
            toolStripButtonSave.Text = "Save";
            toolStripButtonSave.Click += ToolStripButtonSave_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripButtonRun
            // 
            toolStripButtonRun.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRun.Image = (Image)resources.GetObject("toolStripButtonRun.Image");
            toolStripButtonRun.ImageTransparentColor = Color.Magenta;
            toolStripButtonRun.Name = "toolStripButtonRun";
            toolStripButtonRun.Size = new Size(23, 22);
            toolStripButtonRun.Text = "Run";
            toolStripButtonRun.Click += ToolStripButtonRun_Click;
            // 
            // toolStripButtonStop
            // 
            toolStripButtonStop.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonStop.Image = (Image)resources.GetObject("toolStripButtonStop.Image");
            toolStripButtonStop.ImageTransparentColor = Color.Magenta;
            toolStripButtonStop.Name = "toolStripButtonStop";
            toolStripButtonStop.Size = new Size(23, 22);
            toolStripButtonStop.Text = "Stop";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 599);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1027, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // FormDataSourceView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 621);
            Controls.Add(splitContainerVert);
            Controls.Add(toolStripHeader);
            Controls.Add(statusStrip1);
            MinimizeBox = false;
            Name = "FormDataSourceView";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormMain";
            Load += FormEditDataView_Load;
            splitContainerHoriz.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerHoriz).EndInit();
            splitContainerHoriz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            splitContainerVert.Panel1.ResumeLayout(false);
            splitContainerVert.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerVert).EndInit();
            splitContainerVert.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStripHeader.ResumeLayout(false);
            toolStripHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SplitContainer splitContainerHoriz;
        private SplitContainer splitContainerVert;
        private ListView listViewFields;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderAlias;
        private ColumnHeader columnHeaderType;
        private ToolStrip toolStripHeader;
        private ToolStripButton toolStripButtonSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonRun;
        private ToolStripButton toolStripButtonStop;
        private DataGridView dataGridViewResults;
        private StatusStrip statusStrip1;
        private Panel panel1;
        private Label labelDescription;
        private Label labelName;
        private TextBox textBoxDescription;
        private TextBox textBoxName;
        private ComboBox comboBoxDatasource;
        private Label labelDatasource;
    }
}