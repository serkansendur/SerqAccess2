using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerqAccess.EasyData
{
    public class SQLDBManagerFactory : DBManagerFactory
    {
        public SQLDBManagerFactory(string connString)
            : base(connString)
        { }

        public override DBManager GetDBManager()
        {
            return new SQLDBManager(base.connString);
        }
    }
}
