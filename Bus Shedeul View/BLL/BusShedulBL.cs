using Bus_Shedeul_View.DAL;
using Bus_Shedeul_View.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Shedeul_View.BLL
{
    class BusShedulBL
    {

        public bool SaveNewBusShedulBL(BusShedul aShedul)
        {
            if (aShedul.BusName == "" || aShedul.StartFrom == "" || aShedul.ArriveTo == "" || aShedul.DriverName == "" || aShedul.TypeOfTrip == "" || aShedul.Time == "")
            {
                return false;
            }

            else
            {
                BusShedulDA busShedulDAOBj = new BusShedulDA();
                bool result = busShedulDAOBj.SaveNewBusShedulToDB(aShedul);
                return result;
            }
        }

        public bool UpdateNewBusShedulBL(BusShedul aShedul)
        {
            if (aShedul.BusName == "" || aShedul.StartFrom == "" || aShedul.ArriveTo == "" || aShedul.DriverName == "" || aShedul.TypeOfTrip == "" || aShedul.Time == "")
            {
                return false;
            }

            else
            {
                BusShedulDA busShedulDAOBj = new BusShedulDA();
                bool result = busShedulDAOBj.UpdateNewBusShedulToDB(aShedul);
                return result;
            }
        }

        public bool DeleteBusShedulBL(BusShedul aShedul)
        {
            if (aShedul.BusName == "" || aShedul.StartFrom == "" || aShedul.ArriveTo == "" || aShedul.DriverName == "" || aShedul.TypeOfTrip == "" || aShedul.Time == "")
            {
                return false;
            }

            else
            {
                BusShedulDA busShedulDAOBj = new BusShedulDA();
                bool result = busShedulDAOBj.DeleteBusShedulFromDB(aShedul);
                return result;
            }
        }

        public DataTable GetExistingdBusShedulBL()
        {
            DataTable dt = new DataTable();
            BusShedulDA busDAOBj = new BusShedulDA();
            dt = busDAOBj.GetExistingBusShedulFromDB();
            return dt;

        }

      ////Extra Work////
       /* public DataTable InsertIntoComboBoxBL(BusShedul aShedul)
        {
            DataTable dt = new DataTable();
            BusShedulDA busDAOBj = new BusShedulDA();
            dt = busDAOBj.InsertIntoComboBoxDB();
            return dt;
        }*/

    }
}
