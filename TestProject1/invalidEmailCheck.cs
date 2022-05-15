using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;
namespace AtomationP
{
    class invalidEmailCheck:BaseMethods
    {
        public static void invalidEmail(string key)
        {
            Click(propertype.Xpath, "//*[@class='login']");
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='email_create']", key);
            wait(2000);
            Click(propertype.Xpath, "//button[@id='SubmitCreate']");
            wait(5000);
        }
    }
}
