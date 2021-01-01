using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Code for Directory Selector.
/// Almost got scrapped because of a weird error.
/// </summary>

namespace BlocklandManager
{
    public partial class Directory : Form
    {
        public string nameDirectory = ""; 

        public Directory()
        {
            
        }
        
        private void Browse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                nameDirectory = folderBrowserDialog.SelectedPath;   // Storing the value in a temporary string.
                directoryName.Text = nameDirectory; //Copy value to text box.

        }
        private void launchManager()
        {
            Main managerMain = new Main();
            managerMain.MdiParent = (Form)Container;
            managerMain.Show();
            managerMain.webBrowser1.Navigate(folderBrowserDialog.SelectedPath);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            launchManager();
            this.Hide(); //Hides form, user no longer needs it.
            this.Close();
            this.Dispose();
        }
    }
}
