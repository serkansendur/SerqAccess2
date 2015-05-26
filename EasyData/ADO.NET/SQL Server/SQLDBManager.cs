using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SerqAccess.EasyData
{
    public class SQLDBManager : DBManager
    {
        private SqlConnection conn;

        public SQLDBManager(string connString):base(connString)
        {
            conn = new SqlConnection(connString);
        }

        public override void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
        }

        public override IDataReader ReadWithProc(string procName, List<DBParam> parameters)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = procName;
            comm.Connection = conn;
            if (parameters != null)
            {
                comm.Parameters.AddRange(parameters.Select(dbParam => new SqlParameter()
                    {
                        ParameterName = dbParam.ParameterName, SqlDbType = SQLDBTypeMapper.GetDBType(dbParam), Direction = dbParam.Direction, Value = dbParam.Value, 
                    }).ToArray());
            }
            return comm.ExecuteReader();
        }

        public override IDataReader ReadWithSQL(string SQL)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = SQL;
            comm.Connection = conn;
            return comm.ExecuteReader();
        }

        /// <summary>
        /// Uses ExecuteNonQuery and returns number of affected rows unless getReturnValue = true,
        /// in which case it returns the stored procedure return value.
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
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

            var comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = procName;
            comm.Connection = conn;
            if (parameters.Any())
            {
                comm.Parameters.AddRange(parameters.Select(dbParam => new SqlParameter()
                {
                    ParameterName = dbParam.ParameterName,
                    SqlDbType = SQLDBTypeMapper.GetDBType(dbParam),
                    Direction = dbParam.Direction,
                    Value = dbParam.Value,
                }).ToArray());
            }

            int result = comm.ExecuteNonQuery();

            if (getReturnValue)
                result = (int)comm.Parameters[returnValueParamIndex].Value;
            
            return result;
        }
       
        public override int PutWithSQL(string SQL)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = SQL;
            comm.Connection = conn;
            int result = comm.ExecuteNonQuery();
            return result;
        }

        public override void Dispose()
        {
           conn.Close();
           conn.Dispose();
        }
       
    }
}
