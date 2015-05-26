using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerqAccess.EasyData
{
    public enum CommonDbType
    {
        Integer,
        DateTime,
        Boolean,
        ShortString,

        /// <summary>
        /// Use this for unicode (2-byte character) strings (nvarchar in SQL)
        /// </summary>
        StringUnicode,

        /// <summary>
        /// Use this for ASCII (1-byte character) strings (varchar in SQL)
        /// </summary>
        StringAscii,

        /// <summary>
        /// Use this for unicode "ntext" database type (ntext in SQL)
        /// </summary>
        TextUnicode,

        /// <summary>
        /// Use this for ascii "text" database type (text in SQL)
        /// </summary>
        TextAscii,

        Guid,
        // Use decimal in c# to correspond to Money in SQL
        Money
    }
}
