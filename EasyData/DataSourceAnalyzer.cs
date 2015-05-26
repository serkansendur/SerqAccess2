using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerqAccess.EasyData
{
    public class DataSourceAnalyzer
    {
        public static List<string> RetrieveAllDataProviders()
        {
            List<string> rows = new List<string>();
            DataTable _table = DbProviderFactories.GetFactoryClasses();
            foreach (DataRow row in _table.Rows)
            {
                rows.Add(row["Name"].ToString());
            }
            return rows;
        }

        public static List<string> RetrieveAllDataSourcesByProvider(string dataSourceName)
        {
            List<string> rows = new List<string>();
            DbProviderFactory _ftry = DbProviderFactories.GetFactory(dataSourceName);
            DbDataSourceEnumerator _datasourceEnum = _ftry.CreateDataSourceEnumerator();
            DataTable _datasources = _datasourceEnum.GetDataSources();

            foreach (DataRow row in _datasources.Rows)
            {
                rows.Add(row["ServiceName"].ToString());
            }
            return rows;
        }

        public static List<string> RetrieveAllDataSources()
        {
            List<string> rows = new List<string>();
            DataTable _table = DbProviderFactories.GetFactoryClasses();
            foreach (DataRow row in _table.Rows)
            {
                DbProviderFactory _ftry = DbProviderFactories.GetFactory(row);
                DbDataSourceEnumerator _datasourceEnum = _ftry.CreateDataSourceEnumerator();
                if (_datasourceEnum != null)
                {
                    DataTable _datasources = _datasourceEnum.GetDataSources();
                    foreach (DataRow dsRow in _datasources.Rows)
                    {
                        try
                        {
                            rows.Add(dsRow["ServiceName"].ToString());
                        }
                        catch
                        { }

                    }
                }
            }
            return rows;
        }

        public static Dictionary<string, string> RetrieveAllDataSourcesDict()
        {
            Dictionary<string, string> rows = new Dictionary<string, string>();
            DataTable _table = DbProviderFactories.GetFactoryClasses();
            foreach (DataRow row in _table.Rows)
            {
                DbProviderFactory _ftry = DbProviderFactories.GetFactory(row);
                DbDataSourceEnumerator _datasourceEnum = _ftry.CreateDataSourceEnumerator();
                if (_datasourceEnum != null)
                {
                    DataTable _datasources = _datasourceEnum.GetDataSources();
                    foreach (DataRow dsRow in _datasources.Rows)
                    {
                        try
                        {
                            rows.Add(row["Name"].ToString(), dsRow["ServiceName"].ToString());
                        }
                        catch
                        { }

                    }
                }
            }
            return rows;
        }
    }
}
