using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;
namespace OpenMRS
{
    class loginLogout:BaseMethods
    {
        public static void login()
        {
            //Login
            SendKeys(propertype.Id, "username", "admin");
            wait(2000);
            SendKeys(propertype.Id, "password", "Admin123");
            wait(2000);
            Click(propertype.Id, "Inpatient Ward");
            wait(2000);
            Click(propertype.Id, "loginButton");
            wait(5000);
            
        }
        public static void logOut()
        {
            //Logout
            Click(propertype.Xpath, "//div[@id='navbarSupportedContent']//li[3]//a");
            wait(2000);
        }

    }
}
