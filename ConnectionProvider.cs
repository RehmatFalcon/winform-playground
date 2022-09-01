using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public static class ConnectionProvider
    {
        public static IDbConnection GetDbConnection()
        {
            return new MySqlConnection("Server=localhost;Database=dbName;Uid=root;Pwd=;");
        }
    }
}
