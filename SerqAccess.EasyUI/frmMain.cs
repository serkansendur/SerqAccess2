using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerqAccess.EasyUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnDBConnect_Click(object sender, EventArgs e)
        {
            frmDBConnect frm = frmDBConnect.GetInstance();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.BringToFront();
            frm.Show();
        }

        private void buildCommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuildCommands frm = frmBuildCommands.GetInstance();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.BringToFront();
            frm.Show();
        }
    }
}
