using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweakUtility.Helpers;
//thanks to craftplacer for helping me
namespace BlocklandManager

{
    /// <summary>
    /// tests the icon, code recycled from MS2start from the defunct pre-ChazizTech division known as "BetaLike"
    /// </summary>
    public partial class Start : Form
    {
        private readonly Image explorerIcon = Icon.ExtractAssociatedIcon(@"C:\Windows\explorer.exe").ToBitmap();
        private readonly Image myPCIcon = NativeHelpers.ExtractIcon(@"%SystemRoot%\system32\imageres.dll", -109).ToBitmap();
        private readonly Image controlPanelIcon = NativeHelpers.ExtractIcon(@"%SystemRoot%\system32\imageres.dll", -27).ToBitmap();
        private readonly Image desktopIcon = NativeHelpers.ExtractIcon(@"%SystemRoot%\system32\imageres.dll", -110).ToBitmap();
        private readonly Image desktopBackground = GetBackground();

        public Start()
        {
            InitializeComponent();
        }

        private void Explorer_Paint(object sender, PaintEventArgs e)
        {
            //                              X -\/  \/- Y
            e.Graphics.DrawImage(explorerIcon, 15, 15); //Change position if you want.
            e.Graphics.DrawString("Windows Explorer", Explorer.Font, new SolidBrush(Explorer.ForeColor), new RectangleF(15, 84, 100, 0));
            //                                                                                                      X  Y  Width Height
        }

        private void MyPC_Paint(object sender, PaintEventArgs e)
        {
            //                              X -\/  \/- Y
            e.Graphics.DrawImage(myPCIcon, 15, 15); //Change position if you want.
            e.Graphics.DrawString("Computer", Explorer.Font, new SolidBrush(myPC.ForeColor), new RectangleF(14, 84, 100, 0));
            //                                                                                                      X  Y  Width Height
        }

        private void ControlPanel_Paint(object sender, PaintEventArgs e)
        {
            //                              X -\/  \/- Y
            e.Graphics.DrawImage(controlPanelIcon, 15, 15); //Change position if you want.
            e.Graphics.DrawString("Control Panel", Explorer.Font, new SolidBrush(controlPanel.ForeColor), new RectangleF(14, 84, 0, 0));
            //                                                                                                      X  Y  Width Height
        }

        private void Desktop_Paint(object sender, PaintEventArgs e)
        {
            //                              X -\/  \/- Y
            e.Graphics.DrawImage(desktopIcon, 15, 15); //Change position if you want.
            e.Graphics.DrawString("Desktop", Explorer.Font, new SolidBrush(controlPanel.ForeColor), new RectangleF(14, 84, 0, 0));
            e.Graphics.DrawImage(desktopBackground, 150, 6, 269, 126);
            //                                                                                                      X  Y  Width Height
        }

        private void Wallpaper_Paint(object sender, PaintEventArgs e)
        {
            //                              X -\/  \/- Y
            e.Graphics.DrawImage(desktopIcon, 15, 15); //Change position if you want.
            e.Graphics.DrawString("Desktop", Explorer.Font, new SolidBrush(controlPanel.ForeColor), new RectangleF(14, 84, 0, 0));
            //                                                                                                      X  Y  Width Height
        }

        private void ShowAbout(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }

        private static Image GetBackground()
        {
            using (var r = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop"))
            {
                return Image.FromFile((string)r.GetValue("WallPaper"));
            }
        }

        private void Explorer_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Diagnostics.Process.Start("explorer.exe");
        }

        private void MyPC_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Diagnostics.Process.Start("::{20d04fe0-3aea-1069-a2d8-08002b30309d}");
        }

        private void Desktop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ControlPanel_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Diagnostics.Process.Start("::{26EE0668-A00A-44D7-9371-BEB064C98683}");
        }
    }
}