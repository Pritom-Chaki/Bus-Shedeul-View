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
    class TypeOfTripDA
    {
        public bool SaveNewTypeToDB(TypeOfTrip aType)
        {
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "INSERT INTO TypeTable VALUES('" + aType.TypeNo + "','" + aType.TypeName + "')";
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

        public bool UpdateNewTypeToDB(TypeOfTrip aType)
        {
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "UPDATE TypeTable SET TypeNo = '" + aType.TypeNo + "', TypeName = '" + aType.TypeName + "' WHERE TypeNo = '" + aType.TypeNo + "'";
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

        public bool DeleteTypeFromDB(TypeOfTrip aType)
        {
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "DELETE FROM TypeTable WHERE TypeNo = '" + aType.TypeNo + "'";
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

        public DataTable GetExistingTypeFromDB()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "select * from TypeTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            adapter.Dispose();
            return dt;
        }
    }
}
