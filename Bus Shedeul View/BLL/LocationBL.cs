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
    class LocationBL
    {

        public bool SaveNewLocationBL(Location aLocation)
        {
            if (aLocation.LocationName == "" || aLocation.Details == "" )
            {
                return false;
            }

            else
            {
                LocationDA locationDAOBj = new LocationDA();
                bool result = locationDAOBj.SaveNewLocationToDB(aLocation);
                return result;
            }
        }

        public bool UpdateNewLocationBL(Location aLocation)
        {
            if (aLocation.LocationName == "" || aLocation.Details == "")
            {
                return false;
            }

            else
            {
                LocationDA locationDAOBj = new LocationDA();
                bool result = locationDAOBj.UpdateNewLocationToDB(aLocation);
                return result;
            }
        }

        public bool DeleteALocationBL(Location aLocation)
        {
            if (aLocation.LocationName == "" || aLocation.Details == "")
            {
                return false;
            }

            else
            {
                LocationDA locationDAOBj = new LocationDA();
                bool result = locationDAOBj.DeleteLocationFromDB(aLocation);
                return result;
            }
        }

        public DataTable GetExistingdBusBL()
        {
            DataTable dt = new DataTable();
            LocationDA locationDAOBj = new LocationDA();
            dt = locationDAOBj.GetExistingLocationFromDB();
            return dt;

        }
    }
}

