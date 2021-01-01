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
/// The main window for the manager.
/// </summary>

namespace BlocklandManager
{
    public partial class Main : Form
    {
        public string directoryLink = "";
        public Main()
        {
            InitializeComponent();
            this.MdiParent = (Form)Container;
        }
        static void directoryFormDone()
        //gets rid of the Directory Form when no longer needed. This took me forever.
        {
            Directory directoryForm = new Directory();
            directoryForm.Close();
            directoryForm.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        //opposite of directoryFormDone()
        {
            Directory directoryForm = new Directory();
            directoryForm.Show();
        }
    }
}
