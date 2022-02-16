using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentInformationSystem.Services
{
    internal class ConnectionManager
    {
        const string ConnectionString = @"Data Source = DESKTOP-0ENQTQS\SQLEXPRESS; Initial Catalog = StudentManagementSystem;" +
                " Integrated Security=True";

        public static SqlConnection connection { get; set; }
        static ConnectionManager()
        {
                connection = new SqlConnection(ConnectionString);
        }
        public static void EnsureConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
    }
}
