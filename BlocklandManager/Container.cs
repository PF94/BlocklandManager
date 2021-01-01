using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlocklandManager
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
            //Directory directoryForm = new Directory();
            //directoryForm.MdiParent = this;
            //directoryForm.Show();
            Main mainForm = new Main();
            mainForm.MdiParent = this;
            mainForm.Show();
        }
    }
}
