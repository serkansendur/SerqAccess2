using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace SerqAccess.EasyData
{
    public class DBParam
    {
        public CommonDbType DbType { get; set; }
       

        private ParameterDirection _direction = ParameterDirection.Input;
        public ParameterDirection Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }  

        public string ParameterName { get; set; }

        private object _value;
        public object Value
        { 
            get { return _value; }
            set { _value = ((value == null) ? DBNull.Value : value); }
        }

        public DBParam(CommonDbType dbType, string parameterName, object value)
        {
            DbType = dbType;
            ParameterName = parameterName;
            Value = value;
        }
    }
}
