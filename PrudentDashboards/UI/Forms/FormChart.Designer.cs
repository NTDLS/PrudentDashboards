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
            listViewDataSourceViewFields = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderType = new ColumnHeader();
            splitContainerHorzFieldSelction = new SplitContainer();
            splitContainerTopFieldSelector = new SplitContainer();
            panel2 = new Panel();
            listViewFilters = new ListView();
            labelFilters = new Label();
            panel4 = new Panel();
            listViewColumns = new ListView();
            columnHeaderColumnFields = new ColumnHeader();
            labelColumns = new Label();
            splitContainerBottomFieldSelector = new SplitContainer();
            panel3 = new Panel();
            listViewRows = new ListView();
            columnHeaderRowFields = new ColumnHeader();
            labelRows = new Label();
            panel5 = new Panel();
            listViewValues = new ListView();
            columnHeaderValueFields = new ColumnHeader();
            labelValues = new Label();
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
            columnHeaderFilterFields = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)splitContainerHoriz).BeginInit();
            splitContainerHoriz.Panel1.SuspendLayout();
            splitContainerHoriz.Panel2.SuspendLayout();
            splitContainerHoriz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerHorzFieldSelction).BeginInit();
            splitContainerHorzFieldSelction.Panel1.SuspendLayout();
            splitContainerHorzFieldSelction.Panel2.SuspendLayout();
            splitContainerHorzFieldSelction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerTopFieldSelector).BeginInit();
            splitContainerTopFieldSelector.Panel1.SuspendLayout();
            splitContainerTopFieldSelector.Panel2.SuspendLayout();
            splitContainerTopFieldSelector.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerBottomFieldSelector).BeginInit();
            splitContainerBottomFieldSelector.Panel1.SuspendLayout();
            splitContainerBottomFieldSelector.Panel2.SuspendLayout();
            splitContainerBottomFieldSelector.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
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
            splitContainerHoriz.Panel1.Controls.Add(listViewDataSourceViewFields);
            splitContainerHoriz.Panel1.Padding = new Padding(5);
            // 
            // splitContainerHoriz.Panel2
            // 
            splitContainerHoriz.Panel2.Controls.Add(splitContainerHorzFieldSelction);
            splitContainerHoriz.Panel2.Controls.Add(dataGridViewResults);
            splitContainerHoriz.Size = new Size(328, 570);
            splitContainerHoriz.SplitterDistance = 252;
            splitContainerHoriz.TabIndex = 1;
            // 
            // listViewDataSourceViewFields
            // 
            listViewDataSourceViewFields.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderType });
            listViewDataSourceViewFields.Dock = DockStyle.Fill;
            listViewDataSourceViewFields.FullRowSelect = true;
            listViewDataSourceViewFields.GridLines = true;
            listViewDataSourceViewFields.LabelEdit = true;
            listViewDataSourceViewFields.Location = new Point(5, 5);
            listViewDataSourceViewFields.Name = "listViewDataSourceViewFields";
            listViewDataSourceViewFields.Size = new Size(318, 242);
            listViewDataSourceViewFields.TabIndex = 1;
            listViewDataSourceViewFields.UseCompatibleStateImageBehavior = false;
            listViewDataSourceViewFields.View = View.Details;
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
            // splitContainerHorzFieldSelction
            // 
            splitContainerHorzFieldSelction.Dock = DockStyle.Fill;
            splitContainerHorzFieldSelction.Location = new Point(0, 0);
            splitContainerHorzFieldSelction.Name = "splitContainerHorzFieldSelction";
            splitContainerHorzFieldSelction.Orientation = Orientation.Horizontal;
            // 
            // splitContainerHorzFieldSelction.Panel1
            // 
            splitContainerHorzFieldSelction.Panel1.Controls.Add(splitContainerTopFieldSelector);
            // 
            // splitContainerHorzFieldSelction.Panel2
            // 
            splitContainerHorzFieldSelction.Panel2.Controls.Add(splitContainerBottomFieldSelector);
            splitContainerHorzFieldSelction.Size = new Size(328, 314);
            splitContainerHorzFieldSelction.SplitterDistance = 159;
            splitContainerHorzFieldSelction.TabIndex = 4;
            // 
            // splitContainerTopFieldSelector
            // 
            splitContainerTopFieldSelector.Dock = DockStyle.Fill;
            splitContainerTopFieldSelector.Location = new Point(0, 0);
            splitContainerTopFieldSelector.Name = "splitContainerTopFieldSelector";
            // 
            // splitContainerTopFieldSelector.Panel1
            // 
            splitContainerTopFieldSelector.Panel1.Controls.Add(panel2);
            // 
            // splitContainerTopFieldSelector.Panel2
            // 
            splitContainerTopFieldSelector.Panel2.Controls.Add(panel4);
            splitContainerTopFieldSelector.Size = new Size(328, 159);
            splitContainerTopFieldSelector.SplitterDistance = 171;
            splitContainerTopFieldSelector.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(listViewFilters);
            panel2.Controls.Add(labelFilters);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 159);
            panel2.TabIndex = 3;
            // 
            // listViewFilters
            // 
            listViewFilters.Columns.AddRange(new ColumnHeader[] { columnHeaderFilterFields });
            listViewFilters.Dock = DockStyle.Fill;
            listViewFilters.FullRowSelect = true;
            listViewFilters.GridLines = true;
            listViewFilters.Location = new Point(0, 15);
            listViewFilters.MultiSelect = false;
            listViewFilters.Name = "listViewFilters";
            listViewFilters.Size = new Size(171, 144);
            listViewFilters.TabIndex = 0;
            listViewFilters.UseCompatibleStateImageBehavior = false;
            listViewFilters.View = View.Details;
            // 
            // labelFilters
            // 
            labelFilters.AutoSize = true;
            labelFilters.Dock = DockStyle.Top;
            labelFilters.Location = new Point(0, 0);
            labelFilters.Name = "labelFilters";
            labelFilters.Size = new Size(38, 15);
            labelFilters.TabIndex = 1;
            labelFilters.Text = "Filters";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(listViewColumns);
            panel4.Controls.Add(labelColumns);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(153, 159);
            panel4.TabIndex = 3;
            // 
            // listViewColumns
            // 
            listViewColumns.Columns.AddRange(new ColumnHeader[] { columnHeaderColumnFields });
            listViewColumns.Dock = DockStyle.Fill;
            listViewColumns.FullRowSelect = true;
            listViewColumns.GridLines = true;
            listViewColumns.Location = new Point(0, 15);
            listViewColumns.MultiSelect = false;
            listViewColumns.Name = "listViewColumns";
            listViewColumns.Size = new Size(153, 144);
            listViewColumns.TabIndex = 0;
            listViewColumns.UseCompatibleStateImageBehavior = false;
            listViewColumns.View = View.Details;
            // 
            // columnHeaderColumnFields
            // 
            columnHeaderColumnFields.Text = "Column Fields";
            columnHeaderColumnFields.Width = 130;
            // 
            // labelColumns
            // 
            labelColumns.AutoSize = true;
            labelColumns.Dock = DockStyle.Top;
            labelColumns.Location = new Point(0, 0);
            labelColumns.Name = "labelColumns";
            labelColumns.Size = new Size(55, 15);
            labelColumns.TabIndex = 1;
            labelColumns.Text = "Columns";
            // 
            // splitContainerBottomFieldSelector
            // 
            splitContainerBottomFieldSelector.Dock = DockStyle.Fill;
            splitContainerBottomFieldSelector.Location = new Point(0, 0);
            splitContainerBottomFieldSelector.Name = "splitContainerBottomFieldSelector";
            // 
            // splitContainerBottomFieldSelector.Panel1
            // 
            splitContainerBottomFieldSelector.Panel1.Controls.Add(panel3);
            // 
            // splitContainerBottomFieldSelector.Panel2
            // 
            splitContainerBottomFieldSelector.Panel2.Controls.Add(panel5);
            splitContainerBottomFieldSelector.Size = new Size(328, 151);
            splitContainerBottomFieldSelector.SplitterDistance = 171;
            splitContainerBottomFieldSelector.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(listViewRows);
            panel3.Controls.Add(labelRows);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(171, 151);
            panel3.TabIndex = 3;
            // 
            // listViewRows
            // 
            listViewRows.Columns.AddRange(new ColumnHeader[] { columnHeaderRowFields });
            listViewRows.Dock = DockStyle.Fill;
            listViewRows.FullRowSelect = true;
            listViewRows.GridLines = true;
            listViewRows.Location = new Point(0, 15);
            listViewRows.MultiSelect = false;
            listViewRows.Name = "listViewRows";
            listViewRows.Size = new Size(171, 136);
            listViewRows.TabIndex = 0;
            listViewRows.UseCompatibleStateImageBehavior = false;
            listViewRows.View = View.Details;
            // 
            // columnHeaderRowFields
            // 
            columnHeaderRowFields.Text = "Row Fields";
            columnHeaderRowFields.Width = 130;
            // 
            // labelRows
            // 
            labelRows.AutoSize = true;
            labelRows.Dock = DockStyle.Top;
            labelRows.Location = new Point(0, 0);
            labelRows.Name = "labelRows";
            labelRows.Size = new Size(35, 15);
            labelRows.TabIndex = 1;
            labelRows.Text = "Rows";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(listViewValues);
            panel5.Controls.Add(labelValues);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(153, 151);
            panel5.TabIndex = 3;
            // 
            // listViewValues
            // 
            listViewValues.Columns.AddRange(new ColumnHeader[] { columnHeaderValueFields });
            listViewValues.Dock = DockStyle.Fill;
            listViewValues.FullRowSelect = true;
            listViewValues.GridLines = true;
            listViewValues.Location = new Point(0, 15);
            listViewValues.MultiSelect = false;
            listViewValues.Name = "listViewValues";
            listViewValues.Size = new Size(153, 136);
            listViewValues.TabIndex = 0;
            listViewValues.UseCompatibleStateImageBehavior = false;
            listViewValues.View = View.Details;
            // 
            // columnHeaderValueFields
            // 
            columnHeaderValueFields.Text = "Value Fields";
            columnHeaderValueFields.Width = 130;
            // 
            // labelValues
            // 
            labelValues.AutoSize = true;
            labelValues.Dock = DockStyle.Top;
            labelValues.Location = new Point(0, 0);
            labelValues.Name = "labelValues";
            labelValues.Size = new Size(40, 15);
            labelValues.TabIndex = 1;
            labelValues.Text = "Values";
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
            // columnHeaderFilterFields
            // 
            columnHeaderFilterFields.Text = "Filter Fields";
            columnHeaderFilterFields.Width = 130;
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
            splitContainerHorzFieldSelction.Panel1.ResumeLayout(false);
            splitContainerHorzFieldSelction.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerHorzFieldSelction).EndInit();
            splitContainerHorzFieldSelction.ResumeLayout(false);
            splitContainerTopFieldSelector.Panel1.ResumeLayout(false);
            splitContainerTopFieldSelector.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerTopFieldSelector).EndInit();
            splitContainerTopFieldSelector.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            splitContainerBottomFieldSelector.Panel1.ResumeLayout(false);
            splitContainerBottomFieldSelector.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerBottomFieldSelector).EndInit();
            splitContainerBottomFieldSelector.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private ListView listViewDataSourceViewFields;
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
        private Panel panel5;
        private Panel panel3;
        private SplitContainer splitContainerHorzFieldSelction;
        private SplitContainer splitContainerTopFieldSelector;
        private Panel panel2;
        private Panel panel4;
        private SplitContainer splitContainerBottomFieldSelector;
        private Label labelFilters;
        private ListView listViewFilters;
        private Label labelColumns;
        private ListView listViewColumns;
        private Label labelRows;
        private ListView listViewRows;
        private Label labelValues;
        private ListView listViewValues;
        private ColumnHeader columnHeaderColumnFields;
        private ColumnHeader columnHeaderRowFields;
        private ColumnHeader columnHeaderValueFields;
        private ColumnHeader columnHeaderFilterFields;
    }
}