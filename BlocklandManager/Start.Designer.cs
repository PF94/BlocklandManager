namespace BlocklandManager
{
    partial class Start
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
            this.version = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.myPC = new System.Windows.Forms.Panel();
            this.Explorer = new System.Windows.Forms.Panel();
            this.Desktop = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.Color.White;
            this.version.Location = new System.Drawing.Point(12, 9);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(187, 17);
            this.version.TabIndex = 0;
            this.version.Text = "MS2start - Start Screen (Beta)";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(187)))), ((int)(((byte)(228)))));
            this.controlPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.controlPanel.Location = new System.Drawing.Point(432, 207);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(138, 138);
            this.controlPanel.TabIndex = 4;
            this.controlPanel.Click += new System.EventHandler(this.ControlPanel_Click);
            this.controlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ControlPanel_Paint);
            // 
            // myPC
            // 
            this.myPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.myPC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.myPC.ForeColor = System.Drawing.Color.White;
            this.myPC.Location = new System.Drawing.Point(288, 207);
            this.myPC.Name = "myPC";
            this.myPC.Size = new System.Drawing.Size(138, 138);
            this.myPC.TabIndex = 5;
            this.myPC.Click += new System.EventHandler(this.MyPC_Click);
            this.myPC.Paint += new System.Windows.Forms.PaintEventHandler(this.MyPC_Paint);
            // 
            // Explorer
            // 
            this.Explorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(218)))), ((int)(((byte)(131)))));
            this.Explorer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Explorer.ForeColor = System.Drawing.Color.Black;
            this.Explorer.Location = new System.Drawing.Point(144, 207);
            this.Explorer.Name = "Explorer";
            this.Explorer.Size = new System.Drawing.Size(138, 138);
            this.Explorer.TabIndex = 6;
            this.Explorer.Click += new System.EventHandler(this.Explorer_Click);
            this.Explorer.Paint += new System.Windows.Forms.PaintEventHandler(this.Explorer_Paint);
            // 
            // Desktop
            // 
            this.Desktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(96)))), ((int)(((byte)(146)))));
            this.Desktop.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Desktop.ForeColor = System.Drawing.Color.White;
            this.Desktop.Location = new System.Drawing.Point(144, 351);
            this.Desktop.Name = "Desktop";
            this.Desktop.Size = new System.Drawing.Size(426, 138);
            this.Desktop.TabIndex = 5;
            this.Desktop.Click += new System.EventHandler(this.Desktop_Click);
            this.Desktop.Paint += new System.Windows.Forms.PaintEventHandler(this.Desktop_Paint);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 599);
            this.Controls.Add(this.Desktop);
            this.Controls.Add(this.Explorer);
            this.Controls.Add(this.myPC);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.version);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MS2start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel myPC;
        private System.Windows.Forms.Panel Explorer;
        private System.Windows.Forms.Panel Desktop;
    }
}

