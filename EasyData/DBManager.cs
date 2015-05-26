using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace SerqAccess.EasyData
{
    public abstract class DBManager : IDisposable
    {
        protected string connString;
        public DBManager(string connString)
        {
            this.connString = connString;
        }

        public abstract IDataReader ReadWithProc(string procName, List<DBParam> parameters = null);
        public abstract int PutWithProc(string procName, List<DBParam> parameters, bool getReturnValue = true);
        public abstract IDataReader ReadWithSQL(string SQL);
        public abstract int PutWithSQL(string SQL);
        public abstract void OpenConnection();
        public abstract void Dispose();

        

    }
}
