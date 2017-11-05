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
    class HelperBL
    {
        public bool SaveNewHelperBL(Helper aHelper)
        {
            if (aHelper.HelperNo == "" || aHelper.Name == "" || aHelper.ContactNo == "")
            {
                return false;
            }

            else
            {
                HelperDA helperDAOBj = new HelperDA();
                bool result = helperDAOBj.SaveNewHelperToDB(aHelper);
                return result;
            }
        }


        public bool UpdateNewHelperBL(Helper aHelper)
        {
            if (aHelper.HelperNo == "" || aHelper.Name == "" || aHelper.ContactNo == "")
            {
                return false;
            }

            else
            {
                HelperDA helperDAOBj = new HelperDA();
                bool result = helperDAOBj.UpdateNewHelperToDB(aHelper);
                return result;
            }
        }

        public bool DeleteHelperBL(Helper aHelper)
        {
            if (aHelper.HelperNo == "" || aHelper.Name == "" || aHelper.ContactNo == "")
            {
                return false;
            }

            else
            {
                HelperDA helperDAOBj = new HelperDA();
                bool result = helperDAOBj.DeleteHelperFromDB(aHelper);
                return result;
            }
        }

        public DataTable GetExistingdDriverBL()
        {
            DataTable dt = new DataTable();
            HelperDA helperDAOBj = new HelperDA();
            dt = helperDAOBj.GetExistingHelperFromDB();
            return dt;

        }
    }
}
