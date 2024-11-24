using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Controller
{
    internal class Database
    {
        private readonly string dbconnection = "Server=localhost;Database=estate_db;Trusted_Connection=True;";
        
        public SqlConnection Get_dbConnection()
        {
            SqlConnection conn = new SqlConnection(dbconnection);
            conn.Open();
            return conn;
        }
    }
}
