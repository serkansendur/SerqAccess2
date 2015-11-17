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
    public partial class frmBuildCommands : Form
    {
        private static frmBuildCommands _instance;
        public static frmBuildCommands GetInstance()
        {
            return _instance = _instance ?? new frmBuildCommands();
        }
        public frmBuildCommands()
        {
            InitializeComponent();
        }
    }
}
