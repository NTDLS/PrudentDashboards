namespace UI
{
    partial class FormChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChart));
            splitContainerHoriz = new SplitContainer();
            listDataViewFields = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderType = new ColumnHeader();
            dataGridViewResults = new DataGridView();
            splitContainerVert = new SplitContainer();
            plotView = new OxyPlot.WindowsForms.PlotView();
            panel1 = new Panel();
            comboBoxDataSourceView = new ComboBox();
            labelDatasource = new Label();
            labelDescription = new Label();
            labelName = new Label();
            textBoxDescription = new TextBox();
            textBoxName = new TextBox();
            toolStripHeader = new ToolStrip();
            toolStripButtonSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonRefresh = new ToolStripButton();
            toolStripButtonStop = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            ((System.ComponentModel.ISupportInitialize)splitContainerHoriz).BeginInit();
            splitContainerHoriz.Panel1.SuspendLayout();
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
            splitContainerHoriz.Location = new Point(2, 2);
            splitContainerHoriz.Name = "splitContainerHoriz";
            splitContainerHoriz.Orientation = Orientation.Horizontal;
            // 
            // splitContainerHoriz.Panel1
            // 
            splitContainerHoriz.Panel1.Controls.Add(listDataViewFields);
            splitContainerHoriz.Panel1.Padding = new Padding(5);
            // 
            // splitContainerHoriz.Panel2
            // 
            splitContainerHoriz.Panel2.Controls.Add(dataGridViewResults);
            splitContainerHoriz.Size = new Size(328, 570);
            splitContainerHoriz.SplitterDistance = 252;
            splitContainerHoriz.TabIndex = 1;
            // 
            // listDataViewFields
            // 
            listDataViewFields.CheckBoxes = true;
            listDataViewFields.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderType });
            listDataViewFields.Dock = DockStyle.Fill;
            listDataViewFields.FullRowSelect = true;
            listDataViewFields.GridLines = true;
            listDataViewFields.LabelEdit = true;
            listDataViewFields.Location = new Point(5, 5);
            listDataViewFields.Name = "listDataViewFields";
            listDataViewFields.Size = new Size(318, 242);
            listDataViewFields.TabIndex = 1;
            listDataViewFields.UseCompatibleStateImageBehavior = false;
            listDataViewFields.View = View.Details;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 200;
            // 
            // columnHeaderType
            // 
            columnHeaderType.Text = "Type";
            columnHeaderType.Width = 100;
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.BackgroundColor = SystemColors.Control;
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Dock = DockStyle.Fill;
            dataGridViewResults.GridColor = SystemColors.Control;
            dataGridViewResults.Location = new Point(0, 0);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.Size = new Size(328, 314);
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
            splitContainerVert.Panel1.Controls.Add(plotView);
            splitContainerVert.Panel1.Controls.Add(panel1);
            splitContainerVert.Panel1MinSize = 650;
            // 
            // splitContainerVert.Panel2
            // 
            splitContainerVert.Panel2.Controls.Add(splitContainerHoriz);
            splitContainerVert.Panel2.Padding = new Padding(2);
            splitContainerVert.Size = new Size(1027, 574);
            splitContainerVert.SplitterDistance = 691;
            splitContainerVert.TabIndex = 2;
            // 
            // plotView
            // 
            plotView.Dock = DockStyle.Fill;
            plotView.Location = new Point(0, 113);
            plotView.Name = "plotView";
            plotView.PanCursor = Cursors.Hand;
            plotView.Size = new Size(691, 461);
            plotView.TabIndex = 3;
            plotView.Text = "plotView";
            plotView.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxDataSourceView);
            panel1.Controls.Add(labelDatasource);
            panel1.Controls.Add(labelDescription);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(textBoxDescription);
            panel1.Controls.Add(textBoxName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(691, 113);
            panel1.TabIndex = 2;
            // 
            // comboBoxDataSourceView
            // 
            comboBoxDataSourceView.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDataSourceView.FormattingEnabled = true;
            comboBoxDataSourceView.Location = new Point(113, 11);
            comboBoxDataSourceView.Name = "comboBoxDataSourceView";
            comboBoxDataSourceView.Size = new Size(512, 23);
            comboBoxDataSourceView.TabIndex = 5;
            // 
            // labelDatasource
            // 
            labelDatasource.AutoSize = true;
            labelDatasource.Location = new Point(12, 14);
            labelDatasource.Name = "labelDatasource";
            labelDatasource.Size = new Size(95, 15);
            labelDatasource.TabIndex = 4;
            labelDatasource.Text = "DataSource View";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(40, 72);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(67, 15);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Description";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(68, 43);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 2;
            labelName.Text = "Name";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(113, 69);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(512, 23);
            textBoxDescription.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(113, 40);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(512, 23);
            textBoxName.TabIndex = 0;
            // 
            // toolStripHeader
            // 
            toolStripHeader.Items.AddRange(new ToolStripItem[] { toolStripButtonSave, toolStripSeparator1, toolStripButtonRefresh, toolStripButtonStop });
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
            // toolStripButtonRefresh
            // 
            toolStripButtonRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRefresh.Image = (Image)resources.GetObject("toolStripButtonRefresh.Image");
            toolStripButtonRefresh.ImageTransparentColor = Color.Magenta;
            toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            toolStripButtonRefresh.Size = new Size(23, 22);
            toolStripButtonRefresh.Text = "Refresh";
            toolStripButtonRefresh.Click += ToolStripButtonRefresh_Click;
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
            // FormChart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 621);
            Controls.Add(splitContainerVert);
            Controls.Add(toolStripHeader);
            Controls.Add(statusStrip1);
            MinimizeBox = false;
            Name = "FormChart";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chart";
            Load += FormEditDataView_Load;
            splitContainerHoriz.Panel1.ResumeLayout(false);
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
        private ListView listDataViewFields;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderType;
        private ToolStrip toolStripHeader;
        private ToolStripButton toolStripButtonSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonRefresh;
        private ToolStripButton toolStripButtonStop;
        private DataGridView dataGridViewResults;
        private StatusStrip statusStrip1;
        private Panel panel1;
        private Label labelDescription;
        private Label labelName;
        private TextBox textBoxDescription;
        private TextBox textBoxName;
        private ComboBox comboBoxDataSourceView;
        private Label labelDatasource;
        private OxyPlot.WindowsForms.PlotView plotView;
    }
}