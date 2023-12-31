﻿namespace UI
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
            listViewFilter = new ListView();
            columnHeaderFilterFields = new ColumnHeader();
            labelFilters = new Label();
            panel4 = new Panel();
            listViewSeries = new ListView();
            columnHeaderSeriesFields = new ColumnHeader();
            labelSeries = new Label();
            splitContainerBottomFieldSelector = new SplitContainer();
            panel3 = new Panel();
            listViewAxis = new ListView();
            columnHeaderAxisFields = new ColumnHeader();
            labelAxis = new Label();
            panel5 = new Panel();
            listViewValue = new ListView();
            columnHeaderValueFields = new ColumnHeader();
            labelValues = new Label();
            splitContainerVert = new SplitContainer();
            splitContainerVertChartBody = new SplitContainer();
            textBoxRowLimit = new TextBox();
            labelRowLimit = new Label();
            comboBoxChartType = new ComboBox();
            labelChartType = new Label();
            comboBoxDataSourceView = new ComboBox();
            labelDatasource = new Label();
            labelDescription = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            textBoxDescription = new TextBox();
            formsPlot = new ScottPlot.FormsPlot();
            toolStripHeader = new ToolStrip();
            toolStripButtonSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonRefresh = new ToolStripButton();
            toolStripButtonStop = new ToolStripButton();
            toolStripButtonProperties = new ToolStripButton();
            toolStripButtonFields = new ToolStripButton();
            statusStrip1 = new StatusStrip();
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
            ((System.ComponentModel.ISupportInitialize)splitContainerVert).BeginInit();
            splitContainerVert.Panel1.SuspendLayout();
            splitContainerVert.Panel2.SuspendLayout();
            splitContainerVert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerVertChartBody).BeginInit();
            splitContainerVertChartBody.Panel1.SuspendLayout();
            splitContainerVertChartBody.Panel2.SuspendLayout();
            splitContainerVertChartBody.SuspendLayout();
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
            panel2.Controls.Add(listViewFilter);
            panel2.Controls.Add(labelFilters);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 159);
            panel2.TabIndex = 3;
            // 
            // listViewFilter
            // 
            listViewFilter.Columns.AddRange(new ColumnHeader[] { columnHeaderFilterFields });
            listViewFilter.Dock = DockStyle.Fill;
            listViewFilter.FullRowSelect = true;
            listViewFilter.GridLines = true;
            listViewFilter.Location = new Point(0, 15);
            listViewFilter.MultiSelect = false;
            listViewFilter.Name = "listViewFilter";
            listViewFilter.Size = new Size(171, 144);
            listViewFilter.TabIndex = 0;
            listViewFilter.UseCompatibleStateImageBehavior = false;
            listViewFilter.View = View.Details;
            // 
            // columnHeaderFilterFields
            // 
            columnHeaderFilterFields.Text = "Filter Fields";
            columnHeaderFilterFields.Width = 130;
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
            panel4.Controls.Add(listViewSeries);
            panel4.Controls.Add(labelSeries);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(153, 159);
            panel4.TabIndex = 3;
            // 
            // listViewSeries
            // 
            listViewSeries.Columns.AddRange(new ColumnHeader[] { columnHeaderSeriesFields });
            listViewSeries.Dock = DockStyle.Fill;
            listViewSeries.FullRowSelect = true;
            listViewSeries.GridLines = true;
            listViewSeries.Location = new Point(0, 15);
            listViewSeries.MultiSelect = false;
            listViewSeries.Name = "listViewSeries";
            listViewSeries.Size = new Size(153, 144);
            listViewSeries.TabIndex = 0;
            listViewSeries.UseCompatibleStateImageBehavior = false;
            listViewSeries.View = View.Details;
            // 
            // columnHeaderSeriesFields
            // 
            columnHeaderSeriesFields.Text = "Series Fields";
            columnHeaderSeriesFields.Width = 130;
            // 
            // labelSeries
            // 
            labelSeries.AutoSize = true;
            labelSeries.Dock = DockStyle.Top;
            labelSeries.Location = new Point(0, 0);
            labelSeries.Name = "labelSeries";
            labelSeries.Size = new Size(87, 15);
            labelSeries.TabIndex = 1;
            labelSeries.Text = "Series (Legend)";
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
            panel3.Controls.Add(listViewAxis);
            panel3.Controls.Add(labelAxis);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(171, 151);
            panel3.TabIndex = 3;
            // 
            // listViewAxis
            // 
            listViewAxis.Columns.AddRange(new ColumnHeader[] { columnHeaderAxisFields });
            listViewAxis.Dock = DockStyle.Fill;
            listViewAxis.FullRowSelect = true;
            listViewAxis.GridLines = true;
            listViewAxis.Location = new Point(0, 15);
            listViewAxis.MultiSelect = false;
            listViewAxis.Name = "listViewAxis";
            listViewAxis.Size = new Size(171, 136);
            listViewAxis.TabIndex = 0;
            listViewAxis.UseCompatibleStateImageBehavior = false;
            listViewAxis.View = View.Details;
            // 
            // columnHeaderAxisFields
            // 
            columnHeaderAxisFields.Text = "Axis Fields";
            columnHeaderAxisFields.Width = 130;
            // 
            // labelAxis
            // 
            labelAxis.AutoSize = true;
            labelAxis.Dock = DockStyle.Top;
            labelAxis.Location = new Point(0, 0);
            labelAxis.Name = "labelAxis";
            labelAxis.Size = new Size(96, 15);
            labelAxis.TabIndex = 1;
            labelAxis.Text = "Axis (Categories)";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(listViewValue);
            panel5.Controls.Add(labelValues);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(153, 151);
            panel5.TabIndex = 3;
            // 
            // listViewValue
            // 
            listViewValue.Columns.AddRange(new ColumnHeader[] { columnHeaderValueFields });
            listViewValue.Dock = DockStyle.Fill;
            listViewValue.FullRowSelect = true;
            listViewValue.GridLines = true;
            listViewValue.Location = new Point(0, 15);
            listViewValue.MultiSelect = false;
            listViewValue.Name = "listViewValue";
            listViewValue.Size = new Size(153, 136);
            listViewValue.TabIndex = 0;
            listViewValue.UseCompatibleStateImageBehavior = false;
            listViewValue.View = View.Details;
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
            // splitContainerVert
            // 
            splitContainerVert.Dock = DockStyle.Fill;
            splitContainerVert.FixedPanel = FixedPanel.Panel2;
            splitContainerVert.Location = new Point(0, 25);
            splitContainerVert.Name = "splitContainerVert";
            // 
            // splitContainerVert.Panel1
            // 
            splitContainerVert.Panel1.Controls.Add(splitContainerVertChartBody);
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
            // splitContainerVertChartBody
            // 
            splitContainerVertChartBody.Dock = DockStyle.Fill;
            splitContainerVertChartBody.FixedPanel = FixedPanel.Panel1;
            splitContainerVertChartBody.Location = new Point(0, 0);
            splitContainerVertChartBody.Name = "splitContainerVertChartBody";
            // 
            // splitContainerVertChartBody.Panel1
            // 
            splitContainerVertChartBody.Panel1.Controls.Add(textBoxRowLimit);
            splitContainerVertChartBody.Panel1.Controls.Add(labelRowLimit);
            splitContainerVertChartBody.Panel1.Controls.Add(comboBoxChartType);
            splitContainerVertChartBody.Panel1.Controls.Add(labelChartType);
            splitContainerVertChartBody.Panel1.Controls.Add(comboBoxDataSourceView);
            splitContainerVertChartBody.Panel1.Controls.Add(labelDatasource);
            splitContainerVertChartBody.Panel1.Controls.Add(labelDescription);
            splitContainerVertChartBody.Panel1.Controls.Add(textBoxName);
            splitContainerVertChartBody.Panel1.Controls.Add(labelName);
            splitContainerVertChartBody.Panel1.Controls.Add(textBoxDescription);
            splitContainerVertChartBody.Panel1MinSize = 250;
            // 
            // splitContainerVertChartBody.Panel2
            // 
            splitContainerVertChartBody.Panel2.Controls.Add(formsPlot);
            splitContainerVertChartBody.Size = new Size(691, 574);
            splitContainerVertChartBody.SplitterDistance = 250;
            splitContainerVertChartBody.TabIndex = 4;
            // 
            // textBoxRowLimit
            // 
            textBoxRowLimit.Location = new Point(7, 377);
            textBoxRowLimit.Name = "textBoxRowLimit";
            textBoxRowLimit.Size = new Size(236, 23);
            textBoxRowLimit.TabIndex = 8;
            textBoxRowLimit.Text = "1000";
            // 
            // labelRowLimit
            // 
            labelRowLimit.AutoSize = true;
            labelRowLimit.Location = new Point(7, 359);
            labelRowLimit.Name = "labelRowLimit";
            labelRowLimit.Size = new Size(60, 15);
            labelRowLimit.TabIndex = 9;
            labelRowLimit.Text = "Row Limit";
            // 
            // comboBoxChartType
            // 
            comboBoxChartType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChartType.FormattingEnabled = true;
            comboBoxChartType.Location = new Point(7, 329);
            comboBoxChartType.Name = "comboBoxChartType";
            comboBoxChartType.Size = new Size(236, 23);
            comboBoxChartType.TabIndex = 7;
            // 
            // labelChartType
            // 
            labelChartType.AutoSize = true;
            labelChartType.Location = new Point(7, 311);
            labelChartType.Name = "labelChartType";
            labelChartType.Size = new Size(63, 15);
            labelChartType.TabIndex = 6;
            labelChartType.Text = "Chart Type";
            // 
            // comboBoxDataSourceView
            // 
            comboBoxDataSourceView.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDataSourceView.FormattingEnabled = true;
            comboBoxDataSourceView.Location = new Point(7, 34);
            comboBoxDataSourceView.Name = "comboBoxDataSourceView";
            comboBoxDataSourceView.Size = new Size(236, 23);
            comboBoxDataSourceView.TabIndex = 5;
            // 
            // labelDatasource
            // 
            labelDatasource.AutoSize = true;
            labelDatasource.Location = new Point(7, 16);
            labelDatasource.Name = "labelDatasource";
            labelDatasource.Size = new Size(94, 15);
            labelDatasource.TabIndex = 4;
            labelDatasource.Text = "Datasource View";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(4, 129);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(67, 15);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Description";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(7, 103);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(236, 23);
            textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(7, 85);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 2;
            labelName.Text = "Name";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(7, 147);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(236, 140);
            textBoxDescription.TabIndex = 1;
            // 
            // formsPlot
            // 
            formsPlot.Dock = DockStyle.Fill;
            formsPlot.Location = new Point(0, 0);
            formsPlot.Margin = new Padding(4, 3, 4, 3);
            formsPlot.Name = "formsPlot";
            formsPlot.Size = new Size(437, 574);
            formsPlot.TabIndex = 0;
            // 
            // toolStripHeader
            // 
            toolStripHeader.Items.AddRange(new ToolStripItem[] { toolStripButtonSave, toolStripSeparator1, toolStripButtonRefresh, toolStripButtonStop, toolStripButtonProperties, toolStripButtonFields });
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
            // toolStripButtonProperties
            // 
            toolStripButtonProperties.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonProperties.Image = (Image)resources.GetObject("toolStripButtonProperties.Image");
            toolStripButtonProperties.ImageTransparentColor = Color.Magenta;
            toolStripButtonProperties.Name = "toolStripButtonProperties";
            toolStripButtonProperties.Size = new Size(23, 22);
            toolStripButtonProperties.Text = "Properties";
            toolStripButtonProperties.ToolTipText = "Properties";
            toolStripButtonProperties.Click += ToolStripButtonProperties_Click;
            // 
            // toolStripButtonFields
            // 
            toolStripButtonFields.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonFields.Image = (Image)resources.GetObject("toolStripButtonFields.Image");
            toolStripButtonFields.ImageTransparentColor = Color.Magenta;
            toolStripButtonFields.Name = "toolStripButtonFields";
            toolStripButtonFields.Size = new Size(23, 22);
            toolStripButtonFields.Text = "toolStripButtonFields";
            toolStripButtonFields.ToolTipText = "Fields";
            toolStripButtonFields.Click += ToolStripButtonFields_Click;
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
            splitContainerVert.Panel1.ResumeLayout(false);
            splitContainerVert.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerVert).EndInit();
            splitContainerVert.ResumeLayout(false);
            splitContainerVertChartBody.Panel1.ResumeLayout(false);
            splitContainerVertChartBody.Panel1.PerformLayout();
            splitContainerVertChartBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerVertChartBody).EndInit();
            splitContainerVertChartBody.ResumeLayout(false);
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
        private StatusStrip statusStrip1;
        private Label labelDescription;
        private Label labelName;
        private TextBox textBoxDescription;
        private TextBox textBoxName;
        private ComboBox comboBoxDataSourceView;
        private Label labelDatasource;
        private Panel panel5;
        private Panel panel3;
        private SplitContainer splitContainerHorzFieldSelction;
        private SplitContainer splitContainerTopFieldSelector;
        private Panel panel2;
        private Panel panel4;
        private SplitContainer splitContainerBottomFieldSelector;
        private Label labelFilters;
        private ListView listViewFilter;
        private Label labelSeries;
        private ListView listViewSeries;
        private Label labelAxis;
        private ListView listViewAxis;
        private Label labelValues;
        private ListView listViewValue;
        private ColumnHeader columnHeaderSeriesFields;
        private ColumnHeader columnHeaderAxisFields;
        private ColumnHeader columnHeaderValueFields;
        private ColumnHeader columnHeaderFilterFields;
        private ToolStripButton toolStripButtonProperties;
        private SplitContainer splitContainerVertChartBody;
        private ToolStripButton toolStripButtonFields;
        private ComboBox comboBoxChartType;
        private Label labelChartType;
        private TextBox textBoxRowLimit;
        private Label labelRowLimit;
        private ScottPlot.FormsPlot formsPlot;
    }
}