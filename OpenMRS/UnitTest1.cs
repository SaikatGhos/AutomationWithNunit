using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System;
using TestLib;
namespace OpenMRS
{
    public class Tests:BaseMethods
    {
        public static ExtentTest Test;
        public static ExtentReports Extent;

        [SetUp]
        public void Setup()
        {
            driverInitializer();
            GoToURL("https://demo.openmrs.org/openmrs/");
        }
        [OneTimeSetUp]
        public void ExtentStart()
        {
            Extent = new ExtentReports();
            var HtmlReporter = new ExtentHtmlReporter(@"C:\Users\SAIKAT\source\repos\TestProject1\OpenMRS\" + DateTime.Now.ToString("_MMddyyyy_hhmmtt") + ".html");
            Extent.AttachReporter(HtmlReporter);
        }
        [Test]
        public void login()
        {
            Test = null;
            Test = Extent.CreateTest("T001").Info("LoginTest");

            try
            {
                loginLogout.login();
                Test.Log(Status.Pass, "Test Pass");
            }
            catch (Exception e)
            {
                Test.Log(Status.Fail, "Test Fail");
                throw;

            }
        }
        [Test]
        public void logout()
        {
            try
            {
                loginLogout.login();
                wait(5000);
                loginLogout.logOut();
                Test.Log(Status.Pass, "Test Pass");
            }
            catch (Exception e)
            {
                Test.Log(Status.Fail, "Test Fail");
                throw;

            }
        }
        [Test]
        public void registerPatient()
        {
            try {
                loginLogout.login();
                wait(2000);
                Click(propertype.Xpath, "//div[@id='apps']//a[3]");
                wait(2000);
                registerPatients.nameReg("Baban", "Das");
                wait(2000);
                registerPatients.genderSelection("M");
                wait(2000);
                registerPatients.dobSelection("25", "4", "1997");
                wait(2000);
                registerPatients.addrsReg();
                wait(2000);
                registerPatients.mobReg();
                wait(2000);
                registerPatients.relativeReg();
                wait(2000);
                registerPatients.confirm();
            }
            catch(Exception e)
            {
                throw;
            }
            
        }
        [Test]
        public void findPatient()
        {
            try
            {
                findApatient.findPatients("Baban");
                wait(2000);
                Test.Log(Status.Pass, "Test Pass");
            }
            catch (Exception e)
            {
                Test.Log(Status.Fail, "Test Fail");
                throw;

            }
        }
        [Test]
        public void viewPatiens()
        {
            try
            {
                viewPatients.viewPatient("Baban");
                Test.Log(Status.Pass, "Test Pass");
            }
            catch (Exception e)
            {
                Test.Log(Status.Fail, "Test Fail");
                throw;

            }
        }
        public void captureVitals()
        {
            try
            {
                viewPatients.viewPatient("Baban");
                Test.Log(Status.Pass, "Test Pass");
            }
            catch (Exception e)
            {
                Test.Log(Status.Fail, "Test Fail");
                throw;

            }
        }
        [TearDown]
        public void tearDn()
        {
            Extent.Flush();
            wait(5000);
            close();
            quit();
        }
    }
}