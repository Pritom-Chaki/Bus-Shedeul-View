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
    class HelperDA
    {
        public bool SaveNewHelperToDB(Helper aHelper)
        {
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "INSERT INTO HelperTable VALUES('" + aHelper.HelperNo + "','" + aHelper.Name + "','" + aHelper.ContactNo + "')";
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected == 1)
            {
                command.Dispose();
                return true;
            }
            else
            {
                command.Dispose();
                return false;
            }

        }



        public bool UpdateNewHelperToDB(Helper aHelper)
        {
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "UPDATE HelperTable SET HelperName = '" + aHelper.Name + "', ContactNo = '" + aHelper.ContactNo + "' WHERE HelperNo ='" + aHelper.HelperNo + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected == 1)
            {
                command.Dispose();
                return true;
            }
            else
            {
                command.Dispose();
                return false;
            }

        }

        public bool DeleteHelperFromDB(Helper aHelper)
        {
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "DELETE FROM HelperTable WHERE HelperNo ='" + aHelper.HelperNo + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected == 1)
            {
                command.Dispose();
                return true;
            }
            else
            {
                command.Dispose();
                return false;
            }
        }

        public DataTable GetExistingHelperFromDB()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "select * from HelperTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            adapter.Dispose();
            return dt;
        }
    }
}
