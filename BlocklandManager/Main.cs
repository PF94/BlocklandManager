using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

/// <summary>
/// The main window for the manager.
/// </summary>

namespace BlocklandManager
{
    public partial class Main : Form
    {
        public string nameDirectory = "";
        public Main()
        {
            InitializeComponent();
            this.MdiParent = (Form)Container;
        }
        private void button1_Click(object sender, EventArgs e)
        //opposite of directoryFormDone()
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            nameDirectory = folderBrowserDialog.SelectedPath;   // Storing the value in a temporary string.
            this.webBrowser1.Navigate(folderBrowserDialog.SelectedPath);
            string curFile = nameDirectory += "/Blockland.exe";
            if (File.Exists(curFile)) // Checks if the folder has the Blockland executable.
            {
                this.webBrowser1.Navigate(folderBrowserDialog.SelectedPath);
            }
            else
            {
                MessageBox.Show("This is not a Blockland installation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
