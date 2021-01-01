namespace BlocklandManager
{
    partial class Container
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocklandInstallationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b4v21LauncherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocklandV21blocklandusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocklandV21SteamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 596);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(909, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerWindowToolStripMenuItem,
            this.blocklandInstallationToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.newToolStripMenuItem.Text = "New...";
            // 
            // managerWindowToolStripMenuItem
            // 
            this.managerWindowToolStripMenuItem.Name = "managerWindowToolStripMenuItem";
            this.managerWindowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.managerWindowToolStripMenuItem.Text = "Manager window";
            this.managerWindowToolStripMenuItem.Click += new System.EventHandler(this.managerWindowToolStripMenuItem_Click);
            // 
            // blocklandInstallationToolStripMenuItem
            // 
            this.blocklandInstallationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b4v21LauncherToolStripMenuItem,
            this.blocklandV21blocklandusToolStripMenuItem,
            this.blocklandV21SteamToolStripMenuItem});
            this.blocklandInstallationToolStripMenuItem.Name = "blocklandInstallationToolStripMenuItem";
            this.blocklandInstallationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.blocklandInstallationToolStripMenuItem.Text = "Blockland Installation";
            // 
            // b4v21LauncherToolStripMenuItem
            // 
            this.b4v21LauncherToolStripMenuItem.Name = "b4v21LauncherToolStripMenuItem";
            this.b4v21LauncherToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.b4v21LauncherToolStripMenuItem.Text = "B4v21 Launcher";
            // 
            // blocklandV21blocklandusToolStripMenuItem
            // 
            this.blocklandV21blocklandusToolStripMenuItem.Name = "blocklandV21blocklandusToolStripMenuItem";
            this.blocklandV21blocklandusToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.blocklandV21blocklandusToolStripMenuItem.Text = "Blockland v21 (blockland.us)";
            // 
            // blocklandV21SteamToolStripMenuItem
            // 
            this.blocklandV21SteamToolStripMenuItem.Name = "blocklandV21SteamToolStripMenuItem";
            this.blocklandV21SteamToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.blocklandV21SteamToolStripMenuItem.Text = "Blockland v21 (Steam)";
            this.blocklandV21SteamToolStripMenuItem.Click += new System.EventHandler(this.blocklandV21SteamToolStripMenuItem_Click);
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 618);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Container";
            this.Text = "Blockland Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocklandInstallationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b4v21LauncherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocklandV21blocklandusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocklandV21SteamToolStripMenuItem;
    }
}