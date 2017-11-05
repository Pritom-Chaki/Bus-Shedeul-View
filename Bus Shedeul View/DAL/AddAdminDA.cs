using Bus_Shedeul_View.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Shedeul_View.DAL
{
    class AddAdminDA
    {

        public bool SaveNewAdminToDB(AddAdmin aAddAdmin)
        {

            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "INSERT INTO AdminTAble  VALUES ('" + aAddAdmin.UserName + "', '" + aAddAdmin.Password + "','" + aAddAdmin.Role + "')";
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected == 1)
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
