using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Shedeul_View.DAL.DAO
{
    class DataBaseConnection
    {
        public static SqlConnection OpenAnSqlConnection()
        {
            string conectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=BusShedule;Integrated Security=True";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conectionString;
            connection.Open();
            // MessageBox.Show("DONE!!");
            return connection;
        }
    }
}
