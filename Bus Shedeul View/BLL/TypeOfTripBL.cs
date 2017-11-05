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
    class TypeOfTripBL
    {
        public bool SaveNewTypeBL(TypeOfTrip aType)
        {
            if (aType.TypeNo == "" || aType.TypeName == "")
            {
                return false;
            }

            else
            {
                TypeOfTripDA typeDAOBj = new TypeOfTripDA();
                bool result = typeDAOBj.SaveNewTypeToDB(aType);
                return result;
            }
        }

        public bool UpdateNewTypeBL(TypeOfTrip aType)
        {
            if (aType.TypeNo == "" || aType.TypeName == "")
            {
                return false;
            }

            else
            {
                TypeOfTripDA typeDAOBj = new TypeOfTripDA();
                bool result = typeDAOBj.UpdateNewTypeToDB(aType);
                return result;
            }
        }

        public bool DeleteTypeBL(TypeOfTrip aType)
        {
            if (aType.TypeNo == "" || aType.TypeName == "")
            {
                return false;
            }

            else
            {
                TypeOfTripDA typeDAOBj = new TypeOfTripDA();
                bool result = typeDAOBj.DeleteTypeFromDB(aType);
                return result;
            }

        }
        public DataTable GetExistingdTypeBL()
        {
            DataTable dt = new DataTable();
            TypeOfTripDA typeDAOBj = new TypeOfTripDA();
            dt = typeDAOBj.GetExistingTypeFromDB();
            return dt;

        }
    }
}