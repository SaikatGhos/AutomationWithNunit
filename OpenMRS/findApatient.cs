using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;
namespace OpenMRS
{
    class findApatient:BaseMethods
    {
        public static void findPatients(string patientName)
        {
            loginLogout.login();
            wait(3000);
            Click(propertype.Xpath, "//*[@id='apps']//child::a[1]");
            wait(2000);
            SendKeys(propertype.Xpath, "//*[@id='patient-search-form']//child::input", patientName);
            wait(3000);
        }
    }
}
