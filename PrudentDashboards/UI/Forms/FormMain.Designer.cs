namespace UI
{
    partial class FormMain
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            administrationToolStripMenuItem = new ToolStripMenuItem();
            datasourcesToolStripMenuItem = new ToolStripMenuItem();
            dataviewsToolStripMenuItem = new ToolStripMenuItem();
            chartsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, administrationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // administrationToolStripMenuItem
            // 
            administrationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { datasourcesToolStripMenuItem, dataviewsToolStripMenuItem, chartsToolStripMenuItem });
            administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            administrationToolStripMenuItem.Size = new Size(98, 20);
            administrationToolStripMenuItem.Text = "Administration";
            // 
            // datasourcesToolStripMenuItem
            // 
            datasourcesToolStripMenuItem.Name = "datasourcesToolStripMenuItem";
            datasourcesToolStripMenuItem.Size = new Size(180, 22);
            datasourcesToolStripMenuItem.Text = "Datasources";
            datasourcesToolStripMenuItem.Click += datasourcesToolStripMenuItem_Click;
            // 
            // dataviewsToolStripMenuItem
            // 
            dataviewsToolStripMenuItem.Name = "dataviewsToolStripMenuItem";
            dataviewsToolStripMenuItem.Size = new Size(180, 22);
            dataviewsToolStripMenuItem.Text = "Dataviews";
            // 
            // chartsToolStripMenuItem
            // 
            chartsToolStripMenuItem.Name = "chartsToolStripMenuItem";
            chartsToolStripMenuItem.Size = new Size(180, 22);
            chartsToolStripMenuItem.Text = "Charts";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "FormMain";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem administrationToolStripMenuItem;
        private ToolStripMenuItem datasourcesToolStripMenuItem;
        private ToolStripMenuItem dataviewsToolStripMenuItem;
        private ToolStripMenuItem chartsToolStripMenuItem;
    }
}