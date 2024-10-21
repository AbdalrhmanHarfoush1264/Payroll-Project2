using clsPayrollDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsPayrollBussinessLayer
{
    public class clsUser
    {
        public static bool CheckUserNameAndPassword(string username, string password)
        {
            return clsUserData.CheckUsernameAndPassword(username, password);
        }
    }
}
