using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerqAccess.EasyUI
{
    public partial class frmBuildCommands : Form
    {
        private ctrlConnectionString _ctrlConnectionString = new ctrlConnectionString();
        private bool _ctrlLoaded = false;
        private static frmBuildCommands _instance;
        public static frmBuildCommands GetInstance()
        {
            return _instance = _instance ?? new frmBuildCommands();
        }
        public frmBuildCommands()
        {
            InitializeComponent();
        }

        private void frmBuildCommands_Load(object sender, EventArgs e)
        {
            if (!_ctrlLoaded)
            {
                pnlConnectionString.Controls.Add(_ctrlConnectionString);
                _ctrlLoaded = true;
            }
        }

        private void pnlConnectionString_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuildCommands_Click(object sender, EventArgs e)
        {
            string SQL = txtSelectStatement.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings[_ctrlConnectionString.SelectedConnectionString].ConnectionString;
           
        }

        
    }
}
