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
    class DriverDA
    {
        public bool SaveNewDriverToDB(Driver aDriver)
        {
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "INSERT INTO DriverTable VALUES('" + aDriver.DriverNo + "','" + aDriver.Name + "','" + aDriver.ContactNo + "')";
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

        public bool UpdateNewDriverToDB(Driver aDriver)
        {
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "UPDATE DriverTable SET DriverName = '" + aDriver.Name + "', ConactNO = '" + aDriver.ContactNo + "' WHERE DriverNo ='" + aDriver.DriverNo + "'";
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

        public bool DeleteDriverFromDB(Driver aDriver)
        {
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "DELETE FROM DriverTable WHERE DriverNo ='" + aDriver.DriverNo + "'";
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

        public DataTable GetExistingDriverFromDB()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "select * from DriverTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            adapter.Dispose();
            return dt;
        }

    }
}
