using Bus_Shedeul_View.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Shedeul_View.DAL
{
    class ChangedPasswordDA
    {

        public bool ChangePasswordToDB(ChangedPassword aPass)
        {

            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "UPDATE AdminTable  SET  Password ='" + aPass.NewPassword + "' WHERE UserName = '" + aPass.UserName + "' AND Password = '" + aPass.OldPassword + "'";
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
