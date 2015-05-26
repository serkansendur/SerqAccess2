using SerqAccess.EasyData.ODBC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerqAccess.EasyData.ODBC
{
    public class ODBCDBManagerFactory : DBManagerFactory
    {
        public ODBCDBManagerFactory(string connString)
            : base(connString)
        { 
        
        }

        public override DBManager GetDBManager()
        {
            return new ODBCDBManager(base.connString);
        }
    }
}
