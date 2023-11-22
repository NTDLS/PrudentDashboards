namespace UI
{
    partial class FormEditDataView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditDataView));
            splitContainerHoriz = new SplitContainer();
            dataGridViewResults = new DataGridView();
            splitContainerVert = new SplitContainer();
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
            toolStripHeader.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainerHoriz
            // 
            splitContainerHoriz.Dock = DockStyle.Fill;
            splitContainerHoriz.Location = new Point(0, 0);
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
            splitContainerHoriz.Size = new Size(633, 574);
            splitContainerHoriz.SplitterDistance = 361;
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
            dataGridViewResults.Size = new Size(633, 209);
            dataGridViewResults.TabIndex = 1;
            // 
            // splitContainerVert
            // 
            splitContainerVert.Dock = DockStyle.Fill;
            splitContainerVert.Location = new Point(0, 25);
            splitContainerVert.Name = "splitContainerVert";
            // 
            // splitContainerVert.Panel1
            // 
            splitContainerVert.Panel1.Controls.Add(splitContainerHoriz);
            // 
            // splitContainerVert.Panel2
            // 
            splitContainerVert.Panel2.Controls.Add(listViewFields);
            splitContainerVert.Panel2.Padding = new Padding(2);
            splitContainerVert.Size = new Size(1027, 574);
            splitContainerVert.SplitterDistance = 633;
            splitContainerVert.TabIndex = 2;
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
            listViewFields.Size = new Size(386, 570);
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
            toolStripButtonRun.Click += toolStripButtonRun_Click;
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
            // FormEditDataView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 621);
            Controls.Add(splitContainerVert);
            Controls.Add(toolStripHeader);
            Controls.Add(statusStrip1);
            Name = "FormEditDataView";
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
    }
}