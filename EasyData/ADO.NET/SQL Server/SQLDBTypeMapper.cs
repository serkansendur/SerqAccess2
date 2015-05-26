using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SerqAccess.EasyData
{
    public class SQLDBTypeMapper
    {
        public static SqlDbType GetDBType(DBParam dbParam)
        {
            var sqlDbType = SqlDbType.NVarChar;
            switch (dbParam.DbType)
            {
                case CommonDbType.Integer:
                    sqlDbType = SqlDbType.Int;
                    break;
                case CommonDbType.DateTime:
                    sqlDbType = SqlDbType.DateTime;
                    break;
                case CommonDbType.Boolean:
                    sqlDbType = SqlDbType.Bit;
                    break;
                case CommonDbType.StringAscii:
                    sqlDbType = SqlDbType.VarChar;
                    break;
                case CommonDbType.StringUnicode:
                    sqlDbType = SqlDbType.NVarChar;
                    break;
                case CommonDbType.Guid:
                    sqlDbType = SqlDbType.UniqueIdentifier;
                    break;
                case CommonDbType.TextAscii:
                    sqlDbType = SqlDbType.Text;
                    break;
                case CommonDbType.TextUnicode:
                    sqlDbType = SqlDbType.NText;
                    break;
                case CommonDbType.Money:
                    sqlDbType = SqlDbType.Money;
                    break;
            }
            return sqlDbType;
        }
    }
}
