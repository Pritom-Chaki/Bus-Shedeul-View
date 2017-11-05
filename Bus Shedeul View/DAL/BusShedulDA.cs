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
    class BusShedulDA
    {
        public bool SaveNewBusShedulToDB(BusShedul aShedul)
        {
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "INSERT INTO ScheduleTable VALUES ('" + aShedul.Time + "','" + aShedul.StartFrom + "','" + aShedul.ArriveTo + "', '" + aShedul.BusName + "', '" + aShedul.NoOfSeat + "', '" + aShedul.TypeOfTrip + "','" + aShedul.DriverName + "', '" + aShedul.DriverContact + "','" + aShedul.HelperName + "', '" + aShedul.HelperContact + "')";
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

      

        public bool UpdateNewBusShedulToDB(BusShedul aShedul)
        {
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "Update ScheduleTable Set Time = '" + aShedul.Time + "', StartFrom = '" + aShedul.StartFrom + "', ArriveTo = '" + aShedul.ArriveTo + "', BusName = '" + aShedul.BusName + "', SeatCapacity = '" + aShedul.NoOfSeat + "', TypeOfTrip = '" + aShedul.TypeOfTrip + "', DriverName = '" + aShedul.DriverName + "', DriverContact = '" + aShedul.DriverContact + "', HelperName = '" + aShedul.HelperName + "', HelperContact = '" + aShedul.HelperContact + "' WHERE BusName = '" + aShedul.BusName + "' AND TIME = '" + aShedul.Time + "'";
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

        public bool DeleteBusShedulFromDB(BusShedul aShedul)
        {
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "DELETE FROM ScheduleTable WHERE BusName = '" + aShedul.BusName + "' AND Time = '" + aShedul.Time + "'";
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

        public DataTable GetExistingBusShedulFromDB()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "select * from ScheduleTable ORDER BY Time";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            adapter.Dispose();
            return dt;
        }


        ///Extra Work///

        /* public DataTable InsertIntoComboBoxDB(BusShedul aShedul)
       {


           SqlConnection con = DataBaseConnection.OpenAnSqlConnection();
           string query = "SELECT * from BusTable";
           SqlCommand command = new SqlCommand(query, con);
           //  cmd.CommandType = CommandType.Text;
           //cmd.CommandText = "SELECT * from BusTable";
            int rowsAffected =  command.ExecuteNonQuery();
           DataTable dt = new DataTable();
           SqlDataAdapter da = new SqlDataAdapter(command);s
           da.Fill(dt);
           return dt;
           //foreach (DataRow dr in dt.Rows)
           //{
           //    busComboBox.Items.Add(dr["BusName"].ToString());
           //}

           //   con.Close();
       }*/

    }
}
