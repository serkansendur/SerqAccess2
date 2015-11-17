using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
         
           string conString = ConfigurationManager.ConnectionStrings[_ctrlConnectionString.SelectedConnectionString].ConnectionString;
            var server = new Server(new ServerConnection { ConnectionString = conString});
            server.ConnectionContext.Connect();
            var database = server.Databases[""];
            var output = new StringBuilder();

            var table = database.Tables[""];
            var scripter = new Scripter(server) { Options = { ScriptData = true } };
            var script = scripter.EnumScript(new SqlSmoObject[] { table });
            foreach (var line in script)
                output.AppendLine(line);

            txtCommandText.Text = output.ToString();
           

        }

        
    }
}
