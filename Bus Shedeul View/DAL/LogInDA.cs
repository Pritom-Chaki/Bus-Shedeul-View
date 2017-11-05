using Bus_Shedeul_View.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Shedeul_View.DAL
{
    class LogInDA
    {
        public bool ConfrimAdminFromDB(LogIn aLogIn)
        {

            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "Select Role From AdminTable where Username = '" + aLogIn.UserName + "' and Password ='" + aLogIn.Password + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            int result = sda.Fill(dt);
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
