using Bus_Shedeul_View.DAL;
using Bus_Shedeul_View.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Shedeul_View.BLL
{
    class LogInBL
    {

        public bool ValidateLogInAndSendToDA(LogIn aLogIn)
        {


            if (aLogIn.UserName == "" || aLogIn.Password == "")
            {

                return false;

            }

            else
            {
                LogInDA aLogInDA = new LogInDA();
                bool result = aLogInDA.ConfrimAdminFromDB(aLogIn);
                return result;

            }

        }
    }
}
