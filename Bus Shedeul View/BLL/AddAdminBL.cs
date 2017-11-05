using Bus_Shedeul_View.DAL;
using Bus_Shedeul_View.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Shedeul_View.BLL
{
    class AddAdminBL
    {

        public bool AddAdminToDB(AddAdmin aAddAdmin)
        {
            if (aAddAdmin.UserName == "" || aAddAdmin.Password == "" || aAddAdmin.Role == "")
            {
                return false;
            }
            else
            {
                AddAdminDA addAdminDAOBj = new AddAdminDA();
                bool result = addAdminDAOBj.SaveNewAdminToDB(aAddAdmin);
                return result;
            }

        }
    }
}
