using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerqAccess.EasyData.ADO.NET.Oracle
{
    public class OracleDBManagerFactory : DBManagerFactory
    {
        public OracleDBManagerFactory(string connString)
            : base(connString)
        { 
        
        }

        public override DBManager GetDBManager()
        {
            return new OracleDBManager(base.connString);
        }
    }
}
