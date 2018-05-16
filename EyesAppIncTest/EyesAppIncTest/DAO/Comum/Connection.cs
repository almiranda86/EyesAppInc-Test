using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EyesAppIncTest.DAO.Comum
{
    public class Connection : DbContext
    {
        static string _serverName = @"(localdb)\MSSQLLocalDB";
        static string _dbName = "master";

        static string connStr = String.Format("Data Source={0}; Initial Catalog={1}; Integrated Security=True; Connect Timeout = 30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False", _serverName, _dbName);

        public Connection()
            : base(connStr)
        {

        }

        public static SqlConnection createConnection() {
            return new SqlConnection(connStr);
        }

    }
}