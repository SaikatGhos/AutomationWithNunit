using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;
namespace AtomationP
{
    class invalidRegCheck:BaseMethods
    {
        public static void invalidRegChech()
        {
            Click(propertype.Xpath, "//*[@class='login']");
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='email_create']", "cixagi4601@hbehs.com");
            wait(2000);
            Click(propertype.Xpath, "//button[@id='SubmitCreate']");
            wait(5000);
            wait(2000);            
            SendKeys(propertype.Xpath, "//input[@id='customer_firstname']", "abc");
            wait(2000);
            wait(2000);
            Click(propertype.Xpath, "//button[@id='submitAccount']");
            wait(2000);
        }
        public static void invalidDetailsCheck()
        {
            Click(propertype.Xpath, "//*[@class='login']");
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='email_create']", "cixagi4600@hbehs.com");
            wait(2000);
            Click(propertype.Xpath, "//button[@id='SubmitCreate']");
            wait(5000);
            wait(2000);
            //Entering Personal Information
            SendKeys(propertype.Xpath, "//input[@id='customer_firstname']", "445599");
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='customer_lastname']", "112233");
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='passwd']", "demoPass");
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='firstname']", "Asim");
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='lastname']", "Bose");
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='address1']", "001100");
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='city']", "cuttak");
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='postcode']", "Anil");
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='phone_mobile']", "Bose");
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='alias']", "Home");

            Click(propertype.Xpath, "//button[@id='submitAccount']");
            wait(2000);
        }
    }
}
