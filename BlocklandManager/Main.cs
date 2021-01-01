using System;
using System.Diagnostics;
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
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                nameDirectory = folderBrowserDialog.SelectedPath;   // Storing the value in a temporary string.
            string curFile = nameDirectory + "\\Blockland.exe";
            if (File.Exists(curFile)) // Checks if the folder has the Blockland executable.
                Debug.WriteLine("Checking file");
            {
                if (File.Exists(nameDirectory + "\\glu2d3d.dll")) // Checks if the folder has a file only available on v0002 installations.
                {
                    MessageBox.Show("This is a Blockland Vanilla installation. Support for Vanilla (v0002) is currently not implemented.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.WriteLine("ERROR - TOO OLD");
                }
                else
                {
                    if (File.Exists(nameDirectory + "\\Blockland.exe")) // Checks if the folder has the Blockland executable.
                    {
                        this.webBrowser1.Navigate(folderBrowserDialog.SelectedPath);
                        Debug.WriteLine("Success!");
                    }
                    else
                    {
                        if (File.Exists(nameDirectory + "\\blocklandv20.exe")) // Checks if the folder has the B4v21 v20 executable.
                        {
                            this.webBrowser1.Navigate(folderBrowserDialog.SelectedPath);
                            Debug.WriteLine("Success! - B4v21 Client");
                        }
                        else
                        MessageBox.Show("This is not a Blockland installation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Debug.WriteLine("ERROR - INVALID INSTALLATION");
                    }
                }
            }
            }
        }
    }