using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using SerqAccess.EasyData.Oracle;
namespace SerqAccess.EasyData.Oracle
{
    public class ODPDBManager : DBManager
    {
        private OracleConnection conn;
        public ODPDBManager(string connString):base(connString)
        {
            conn = new OracleConnection(connString);
        }

        public override void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
        }

        public override IDataReader ReadWithProc(string procName, List<DBParam> parameters = null)
        {
            OracleCommand comm = new OracleCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = procName;
            comm.Connection = conn;
            if (parameters != null)
            {
                comm.Parameters.AddRange(parameters.Select(dbParam => new OracleParameter()
                {
                    ParameterName = dbParam.ParameterName,
                    OracleDbType = ODPDBTypeMapper.GetDBType(dbParam),
                    Direction = dbParam.Direction,
                    Value = dbParam.Value,
                }).ToArray());
            }
            return comm.ExecuteReader();

        }

        public override int PutWithProc(string procName, List<DBParam> parameters, bool getReturnValue = true)
        {
            int returnValueParamIndex = -1;

            if (getReturnValue)
            {
                DBParam returnValueParam = new DBParam(CommonDbType.Integer, "@RETURN_VALUE", 0);
                returnValueParam.Direction = ParameterDirection.ReturnValue;
                returnValueParamIndex = parameters.Count;
                parameters.Add(returnValueParam);
            }

            OracleCommand comm = new OracleCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = procName;
            comm.Connection = conn;
            if (parameters.Any())
            {
                comm.Parameters.AddRange(parameters.Select(dbParam => new OracleParameter()
                {
                    ParameterName = dbParam.ParameterName,
                    OracleDbType = ODPDBTypeMapper.GetDBType(dbParam),
                    Direction = dbParam.Direction,
                    Value = dbParam.Value,
                }).ToArray());
            }

            int result = comm.ExecuteNonQuery();

            if (getReturnValue)
                result = (int)comm.Parameters[returnValueParamIndex].Value;

            return result;
        }

        public override void Dispose()
        {
            conn.Close();
            conn.Dispose();
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
    }
}
