using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using SerqAccess.EasyData.Oracle;
using SerqAccess.EasyData;
using SerqAccess.EasyData.OleDB;
using SerqAccess.EasyData.ODBC;
using SerqAccess.EasyData.ADO.NET.Oracle;

namespace SerqAccess.EasyUI
{
    public partial class ctrlConnectionString : UserControl
    {
        public ctrlConnectionString()
        {
            InitializeComponent();
        }

        public string SelectedConnectionString
        {
            get
            {
                return cbConnectionStrings.SelectedItem.ToString();
            }
        }

        public string SelectedProvider
        {
            get
            {
                return cbProvider.SelectedItem.ToString();
            }
        }

        private void ctrlConnectionString_Load(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection connectionStrings = ConfigurationManager.ConnectionStrings;
            foreach (ConnectionStringSettings conSet in connectionStrings)
            {
                cbConnectionStrings.Items.Add(conSet.Name);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
           string conString = ConfigurationManager.ConnectionStrings[cbConnectionStrings.SelectedItem.ToString()].ConnectionString;
            DBManager dbManager = null;
            try
            {
                string provider = cbProvider.SelectedItem.ToString();
                switch (provider)
                {
                    case "ODP":
                        dbManager = new ODPDBManager(conString);
                        break;
                    case "OLEDB":
                        dbManager = new OleDBManager(conString);
                        break;
                    case "ODBC":
                        dbManager = new ODBCDBManager(conString);
                        break;
                    case "ORACLECLIENT":
                        dbManager = new OracleDBManager(conString);
                        break;
                    case "SQL SERVER":
                        dbManager = new SQLDBManager(conString);
                        break;
                }
                dbManager.OpenConnection();
                MessageBox.Show("Connection succeeded.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
            finally
            {
                if (dbManager != null)
                {
                    dbManager.Dispose();
                }
            }
        }
    }
}
