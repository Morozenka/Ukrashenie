using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    internal class DB
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=morozk\MSSQLSERVER01;Initial Catalog=shir;Integrated Security=True");
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }

        }
        public SqlConnection getConnection()
        {
            return sqlConnection;

        }
    }
}
