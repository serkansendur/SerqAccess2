using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerqAccess.EasyData.ADO.NET.SQL_Server
{
    public class SMOManager
    {
        public void LinkServer()
        {
            Server srv = new Server();
            //Create a linked server. 
            LinkedServer lsrv = default(LinkedServer);
            lsrv = new LinkedServer(srv, "OLEDBSRV");
            //When the product name is SQL Server the remaining properties are 
            //not required to be set. 
            lsrv.ProductName = "SQL Server";
            lsrv.Create(); 
        }
    }
}
