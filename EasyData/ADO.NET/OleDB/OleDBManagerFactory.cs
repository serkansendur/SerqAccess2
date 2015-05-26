using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerqAccess.EasyData.OleDB
{
    public class OleDBManagerFactory : DBManagerFactory
    {
        public OleDBManagerFactory(string connString)
            : base(connString)
        { 
        
        }

        public override DBManager GetDBManager()
        {
            return new OleDBManager(base.connString);
        }
    }
}
