using SerqAccess.EasyData;
using SerqAccess.EasyData.ADO.NET.Oracle;
using SerqAccess.EasyData.EXCEL;
using SerqAccess.EasyData.ODBC;
using SerqAccess.EasyData.OleDB;
using SerqAccess.EasyData.Oracle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerqAccess.EasyUI;

namespace SerqAccess.EasyUI
{
    public partial class frmDBConnect : Form
    {
        private ctrlConnectionString _ctrlConnectionString = new ctrlConnectionString();
        private string conString;
        private bool _ctrlLoaded = false;
        
        private static frmDBConnect _instance;
        public static frmDBConnect GetInstance()
        {
            return _instance = _instance ?? new frmDBConnect();
        }
        private frmDBConnect()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            

        }

        private void ConnectionTest_Load(object sender, EventArgs e)
        {
            if(!_ctrlLoaded)
            {
                pnlConnectionString.Controls.Add(_ctrlConnectionString);
                _ctrlLoaded = true;
            }
           
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings[_ctrlConnectionString.SelectedConnectionString].ConnectionString;
            DBManager dbManager = null;
            try
            {
                string provider = _ctrlConnectionString.SelectedProvider;
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
                using (IDataReader reader = dbManager.ReadWithSQL(txtSQL.Text))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvSQL.DataSource = dt;
                    dtTempForExcel = dt;
                    reader.Close();
                }
                dbManager.Dispose();
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

        private void btnPut_Click(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings[_ctrlConnectionString.SelectedConnectionString].ConnectionString;
            DBManager dbManager = null;
            try
            {
                string provider = _ctrlConnectionString.SelectedProvider;
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
                int result = dbManager.PutWithSQL(txtSQL.Text);
                MessageBox.Show(result.ToString() + " rows affected."); 
                dbManager.Dispose();
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

        DataTable dtTempForExcel = new DataTable();
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExcelWriter.WriteClosed(new List<DataTable>() { dtTempForExcel }, sfd.FileName);
                    MessageBox.Show("Export succeeded.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export failed: " + ex.Message);
                }
                
            }
        }

        private void frmDBConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance = null;
        }

    }
}
