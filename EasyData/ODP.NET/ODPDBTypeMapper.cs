using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace SerqAccess.EasyData.Oracle
{
    public class ODPDBTypeMapper
    {
        public static OracleDbType GetDBType(DBParam dbParam)
        {
            var oracleDbType = OracleDbType.NVarchar2;
            switch (dbParam.DbType)
            {
                case CommonDbType.Integer:
                    oracleDbType = OracleDbType.Int32;
                    break;
                case CommonDbType.DateTime:
                    oracleDbType = OracleDbType.Date;
                    break;
                case CommonDbType.Boolean:
                    oracleDbType = OracleDbType.Char;
                    break;
                case CommonDbType.StringAscii:
                    oracleDbType = OracleDbType.Varchar2;
                    break;
                case CommonDbType.StringUnicode:
                    oracleDbType = OracleDbType.NVarchar2;
                    break;
                case CommonDbType.Guid:
                    oracleDbType = OracleDbType.NVarchar2;
                    break;
                case CommonDbType.TextAscii:
                    oracleDbType = OracleDbType.NVarchar2;
                    break;
                case CommonDbType.TextUnicode:
                    oracleDbType = OracleDbType.NVarchar2;
                    break;
                case CommonDbType.Money:
                    oracleDbType = OracleDbType.Decimal;
                    break;
            }
            return oracleDbType;
        }
    }
}
