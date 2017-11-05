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
    class BusBL
    {

        public bool SaveNewBusBL(Bus aBus)
        {
            if (aBus.BusNO == "" || aBus.BusName == "" || aBus.NoOfSeat =="" )
            {
                return false;
            }

            else
            {
                BusDA studentDAOBj = new BusDA();
                bool result = studentDAOBj.SaveNewBusToDB(aBus);
                return result;
            }
        }

        public bool UpdateNewBusBL(Bus aBus)
        {
            if (aBus.BusNO == "" || aBus.BusName == "" || aBus.NoOfSeat == "")
            {
                return false;
            }

            else
            {
                BusDA studentDAOBj = new BusDA();
                bool result = studentDAOBj.UpdateNewBusToDB(aBus);
                return result;
            }
        }

        public bool DeleteABusBL(Bus aBus)
        {
            if (aBus.BusNO == "" || aBus.BusName == "" || aBus.NoOfSeat == "")
            {
                return false;
            }

            else
            {
                BusDA studentDAOBj = new BusDA();
                bool result = studentDAOBj.DeleteBusFromDB(aBus);
                return result;
            }
        }

        public DataTable GetExistingdBusBL()
        {
            DataTable dt = new DataTable();
            BusDA busDAOBj = new BusDA();
            dt = busDAOBj.GetExistingBusFromDB();
            return dt;

        }
    }
}
