using System;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using TweakUtility.Helpers;

/// <summary>
/// The main window for the manager.
/// </summary>

namespace BlocklandManager
{
    public partial class Main : Form
    {
        private readonly Image explorerIcon = Icon.ExtractAssociatedIcon(statusIcon).ToBitmap();

        public string nameDirectory = "";
        public string statusText = "Not loaded";
        public static string statusIcon = @"C:\Windows\explorer.exe";
        public Main()
        {
            InitializeComponent();
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
                        nameDirectory += "\\Blockland.exe";
                        statusIcon = nameDirectory;
                        this.webBrowser1.Navigate(folderBrowserDialog.SelectedPath);
                        Debug.WriteLine("Success!");
                        statusText = "Blockland";
                        Explorer_PaintAlt(version);
                        Console.WriteLine(statusText);
                    }
                    else
                    {
                        if (File.Exists(nameDirectory + "\\blocklandv20.exe")) // Checks if the folder has the B4v21 v20 executable.
                        {
                            nameDirectory += "\\blocklandv20.exe";
                            statusIcon = nameDirectory;
                            this.webBrowser1.Navigate(folderBrowserDialog.SelectedPath);
                            Debug.WriteLine("Success! - B4v21 Client");
                            statusText = "Blockland v20";
                            Explorer_PaintAlt(version);
                            Console.WriteLine(statusText);
                        }
                        else
                        MessageBox.Show("This is not a Blockland installation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void Explorer_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(explorerIcon, 15, 15); //Change position if you want.
            e.Graphics.DrawString(statusText, version.Font, new SolidBrush(version.ForeColor), new RectangleF(15, 84, 100, 0));
        }

        private void Explorer_PaintAlt(object sender)
        {
            version.CreateGraphics().DrawImage(explorerIcon, 15, 15); //Change position if you want.
            version.CreateGraphics().DrawString(statusText, version.Font, new SolidBrush(version.ForeColor), new RectangleF(15, 84, 100, 0));
        }
    }
    }