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
    class DriverBL
    {
        public bool SaveNewDriverBL(Driver aDriver)
        {
            if (aDriver.DriverNo == "" || aDriver.Name == "" || aDriver.ContactNo == "")
            {
                return false;
            }

            else
            {
                DriverDA driverDAOBj = new DriverDA();
                bool result = driverDAOBj.SaveNewDriverToDB(aDriver);
                return result;
            }
        }

        public bool UpdateNewDriverBL(Driver aDriver)
        {
            if (aDriver.DriverNo == "" || aDriver.Name == "" || aDriver.ContactNo == "")
            {
                return false;
            }

            else
            {
                DriverDA driverDAOBj = new DriverDA();
                bool result = driverDAOBj.UpdateNewDriverToDB(aDriver);
                return result;
            }
        }

        public bool DeleteADriverBL(Driver aDriver)
        {
            if (aDriver.DriverNo == "" || aDriver.Name == "" || aDriver.ContactNo == "")
            {
                return false;
            }

            else
            {
                DriverDA driverDAOBj = new DriverDA();
                bool result = driverDAOBj.DeleteDriverFromDB(aDriver);
                return result;
            }
        }

        public DataTable GetExistingdDriverBL()
        {
            DataTable dt = new DataTable();
            DriverDA driverDAOBj = new DriverDA();
            dt = driverDAOBj.GetExistingDriverFromDB();
            return dt;

        }
    }
}
