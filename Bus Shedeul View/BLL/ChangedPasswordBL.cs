using Bus_Shedeul_View.DAL;
using Bus_Shedeul_View.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Shedeul_View.BLL
{
    class ChangedPasswordBL
    {
        public bool ChangePasswordToDB(ChangedPassword aPass)
        {
            if (aPass.UserName == "" || aPass.OldPassword == "" || aPass.NewPassword == "")
            {
                return false;
            }
            else
            {
                ChangedPasswordDA changePassDAOBj = new ChangedPasswordDA();
                bool result = changePassDAOBj.ChangePasswordToDB(aPass);
                return result;
            }

        }
    }
}
