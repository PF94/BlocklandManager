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
        //private readonly Image explorerIcon = Icon.ExtractAssociatedIcon(statusIcon).ToBitmap();

        public string blocklandExecutable = ""; //This is for the "play" button.
        public string nameDirectory = "";
        public string statusText = "Not loaded";
        //public static string statusIcon = @"C:\Windows\explorer.exe";
        bool isB4v21 = false; //This is set to true when "blocklandv20.exe" is detected.
        public Main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Makes the user select a file, and shittily detects if there's a Blockland installation or not.
        /// This is heavily fucked, because non-v21 clients will be treated as v21 clients, which
        /// will fuck up versions with the old addon system (v1.0x and v8).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                nameDirectory = folderBrowserDialog.SelectedPath;   // Storing the value in a temporary string.
            string curFile = nameDirectory + "\\Blockland.exe";
            if (File.Exists(curFile)) // Checks if the folder has the Blockland executable.
                Debug.WriteLine("Checking file");
            {
                if (File.Exists(nameDirectory + "\\glu2d3d.dll")) // Checks if the folder has a file only available on v0002 installations. 
                    //This file is on the B4v21 launcher, which fools BLManager into thinking it's v0002, and thus gives an unrelated error.
                {
                    MessageBox.Show("This is a Blockland Vanilla installation. Support for Vanilla (v0002) is currently not implemented.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.WriteLine("ERROR - TOO OLD");
                }
                else
                {
                    if (File.Exists(nameDirectory + "\\Blockland.exe")) // Checks if the folder has the Blockland executable.
                    {
                        blocklandExecutable = nameDirectory += "\\Blockland.exe";
                        Debug.WriteLine("Success!");
                        statusText = "Blockland";
                        Console.WriteLine("Status Text: " + statusText);
                        isB4v21 = false;
                        Console.WriteLine("B4v21 Client?: " + isB4v21);
                        InitAfterLoad();
                    }
                    else
                    {
                        if (File.Exists(nameDirectory + "\\blocklandv20.exe")) // Checks if the folder has the B4v21 v20 executable.
                        {
                            blocklandExecutable = nameDirectory += "\\blocklandv20.exe";
                            Debug.WriteLine("Success! - B4v21 Client");
                            statusText = "Blockland v20";
                            Console.WriteLine("Status Text: " + statusText);
                            isB4v21 = true;
                            Console.WriteLine("B4v21 Client?: " + isB4v21);
                            InitAfterLoad();
                        }
                        else
                        MessageBox.Show("This is not a Blockland installation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        /// <summary>
        /// Does the same commands for when a v21 client or a B4v21 v20 client is loaded,
        /// </summary>
        private void InitAfterLoad() 
        {
            this.webBrowser1.Navigate(folderBrowserDialog.SelectedPath);
            Explorer_PaintAlt(version);
            if (isB4v21)
            {
                Console.WriteLine("i is less than j");
            }

        }

        /// <summary>
        /// Draws the text for the grey box. This code is a port from ms2Start, which had a heavily simplified version
        /// of TweakUtility's icon loader helper.
        /// </summary>
        /// <param name="sender"></param>
        private void Explorer_PaintAlt(object sender)
        {
            //version.CreateGraphics().DrawImage(explorerIcon, 15, 15); //Change position if you want.
            version.CreateGraphics().DrawString(statusText, version.Font, new SolidBrush(version.ForeColor), new RectangleF(15, 10, 185, 0));
            //                                                                                                              X  Y  Width Height
        }
    }
    }