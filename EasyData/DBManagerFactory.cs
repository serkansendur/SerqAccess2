using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerqAccess.EasyData
{
    public abstract class DBManagerFactory
    {
        public abstract DBManager GetDBManager();
        protected string connString;
        public DBManagerFactory(string connString)
        {
            this.connString = connString;
        }
    }

   

}
