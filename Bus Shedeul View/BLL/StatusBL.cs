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
    class StatusBL
    {

        public bool UpdateNewStatusBL(Status aStatus)
        { 
            if (aStatus.StatusNo == "" || aStatus.StatusPosition == "" )
            {
                return false;
            }

            else
            {
                StatusDA statusDAOBj = new StatusDA();
                bool result = statusDAOBj.UpdateNewStatusToDB(aStatus);
                return result;
            }
        }


        


        public DataTable GetExistingdStatusBL()
        {
            DataTable dt = new DataTable();
            StatusDA statusDAOBj = new StatusDA();
            dt = statusDAOBj.GetExistingStatusFromDB();
            return dt;

        }

    }
}
