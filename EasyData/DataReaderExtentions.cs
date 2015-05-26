using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SerqAccess.EasyData.Extensions
{
    public static class DataReaderExtentions
    {
        public static T GetValue<T>(this IDataReader dataReader, string fieldName) 
        {
            var value = dataReader[fieldName];
            if (DBNull.Value.Equals(value))
                return default(T);
            else
            {
                return (T)value;
            }
        }

        public static Nullable<T> GetNullableEnumValue<T>(this IDataReader dataReader, string fieldName) where T: struct
        {
            object value = dataReader[fieldName];
            if ((DBNull.Value.Equals(value)) || (value == null))
                return null;
            else
            {
                return (Nullable<T>)(T)value;
            }
        }
    }
}
