using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;
namespace OpenMRS
{
    class registerPatients:BaseMethods
    {
        public static void nameReg(string fname, string lname)
        {
            SendKeys(propertype.Name, "givenName", fname);
            wait(2000);
            SendKeys(propertype.Name, "familyName", lname);
            wait(2000);
            Click(propertype.Id, "next-button");
        }
        public static void genderSelection(string gen)
        {
            if (gen == "M")
                Click(propertype.Xpath, "//*[@id='gender-field']//child::option[1]");
            wait(1000);
            if (gen == "F")
                Click(propertype.Xpath, "//*[@id='gender-field']//child::option[2]");
            wait(2000);
            Click(propertype.Id, "next-button");
            //TabDown();
        }
        public static void dobSelection(string date, string monthNo, string year)
        {
            SendKeys(propertype.Xpath, "//*[@id='birthdateDay-field']", date);
            wait(2000);
            Click(propertype.Xpath, "//*[@id='birthdateMonth-field']//child::option[@value='" + monthNo + "']");
            wait(2000);
            SendKeys(propertype.Xpath, "//*[@id='birthdateYear-field']", year);
            wait(2000);
            Click(propertype.Id, "next-button");
            //TabDown();
        }
        public static void addrsReg()
        {
            SendKeys(propertype.Xpath, "//input[@id='address1']", "Birbhum");
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='address2']", "Birbhum");
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='cityVillage']", "Pipur");
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='stateProvince']", "Howrah");
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='country']", "India");
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@id='postalCode']", "711393");
            wait(2000);
            Click(propertype.Id, "next-button");
            //TabDown();
        }
        public static void mobReg()
        {
            SendKeys(propertype.Xpath, "//input[@name='phoneNumber']", "9754789521");
            wait(2000);
            Click(propertype.Id, "next-button");
            //TabDown();
        }
        public static void relativeReg()
        {
            Click(propertype.Xpath, "//*[@id='relationship']//child::a[1]");
            wait(2000);
            Click(propertype.Xpath, "//*[@id='relationship']//child::a[2]");
            wait(2000);
            Click(propertype.Xpath, "//*[@id='relationship_type']//child::option[5]");
            wait(2000);
            SendKeys(propertype.Xpath, "//input[@placeholder='Person Name']", "Biren");
            wait(2000);
            Click(propertype.Id, "next-button");
            //TabDown();
        }
        public static void confirm()
        {
            wait(2000);
            Click(propertype.Xpath, "//input[@id='submit']");
            wait(5000);
        }
        public static void scheduleAppointment()
        {
            wait(2000);
            Click(propertype.Xpath, "//*[@class='float-left']//child::li[4]//a");
            wait(5000);
        }
        
    }
}
