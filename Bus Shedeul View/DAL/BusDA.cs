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
    class BusDA
    {
        public bool SaveNewBusToDB(Bus aBus)
        {
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "INSERT INTO BusTable VALUES('" + aBus.BusNO + "','" + aBus.BusName + "','" + aBus.NoOfSeat + "')";
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

        public bool UpdateNewBusToDB(Bus aBus)
        {
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "UPDATE BusTable SET BusName = '" + aBus.BusName + "', NoOFSeat = '" + aBus.NoOfSeat + "' WHERE BusNo = '" + aBus.BusNO + "'";
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

        public bool DeleteBusFromDB(Bus aBus)
        {
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "DELETE FROM BusTable WHERE BusNo ='" + aBus.BusNO + "'";
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

        public DataTable GetExistingBusFromDB()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "select * from BusTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            adapter.Dispose();
            return dt;
        }

    }
}
