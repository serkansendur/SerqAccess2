using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerqAccess.EasyData.ADO.NET.Oracle
{
    public class OracleDBManager : DBManager
    {
        private OracleConnection conn;
        public OracleDBManager(string connString)
             : base(connString)
        {
            conn = new OracleConnection(connString);
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
            OracleCommand comm = new OracleCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = SQL;
            comm.Connection = conn;
            return comm.ExecuteReader();
        }

        public override int PutWithSQL(string SQL)
        {
            OracleCommand comm = new OracleCommand();
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
