using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SD = System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class ConnectionClass
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=Krimzon; Initial Catalog=demo; Integrated Security=True");

        public ConnectionClass()
        {

        }
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }

        public void openConnection()
        {
            if (sqlConnection.State == SD.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == SD.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
    }
}
