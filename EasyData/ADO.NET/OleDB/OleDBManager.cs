using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace SerqAccess.EasyData.OleDB
{
    public class OleDBManager : DBManager
    {

        private OleDbConnection conn;
         public OleDBManager(string connString)
             : base(connString)
        {
            conn = new OleDbConnection(connString);
        }

        public override IDataReader ReadWithProc(string procName, List<DBParam> parameters = null)
        {
            throw new NotImplementedException();
        }

        public override int PutWithProc(string procName, List<DBParam> parameters, bool getReturnValue = true)
        {
            throw new NotImplementedException();
        }

        public override IDataReader ReadWithSQL(string SQL)
        {
            OleDbCommand comm = new OleDbCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = SQL;
            comm.Connection = conn;
            return comm.ExecuteReader();
        }

        public override int PutWithSQL(string SQL)
        {
            OleDbCommand comm = new OleDbCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = SQL;
            comm.Connection = conn;
            int result = comm.ExecuteNonQuery();
            return result;
        }

        public override void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
        }

        public override void Dispose()
        {
            conn.Close();
            conn.Dispose();
        }
    }
}
