using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerqAccess.EasyData.Oracle
{
    public class OracleDBManagerFactory : DBManagerFactory
    {
        public OracleDBManagerFactory(string connString):base(connString)
        { 
        
        }

        public override DBManager GetDBManager()
        {
            return new ODPDBManager(base.connString);
        }
    }
}
