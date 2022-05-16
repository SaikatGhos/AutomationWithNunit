using AtomationP;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System;
using TestLib;
namespace TestProject1
{
    public class Tests:BaseMethods
    {
        public static ExtentTest Test;
        public static ExtentReports Extent;
        [SetUp]
        public void Setup()
        {
            driverInitializer();
            GoToURL("http://automationpractice.com/index.php");
        }
        [OneTimeSetUp]
        public void ExtentStart()
        {
            Extent = new ExtentReports();
            var HtmlReporter = new ExtentHtmlReporter(@"C:\Users\SAIKAT\source\repos\TestProject1\TestProject1\" + DateTime.Now.ToString("_MMddyyyy_hhmmtt") + ".html");
            Extent.AttachReporter(HtmlReporter);
        }
        
        [Test]
        public void verifyEmailValidorNot()
        {
            Test = null;
            Test = Extent.CreateTest("T001").Info("verifyEmailValidorNot");
            try {
                invalidEmailCheck.invalidEmail("Abc");
                wait(5000);
                Test.Log(Status.Pass, "Test Pass");
            }
            catch(Exception e) {
                Test.Log(Status.Fail, "Test Fail");
                throw; 
            }
            
        }
        [Test]
        public void VerifyErrorMessagesforMandatoryFields()
        {
            Test = null;
            Test = Extent.CreateTest("T002").Info("VerifyErrorMessagesforMandatoryFields");
            try {
                invalidRegCheck.invalidRegChech();
                wait(5000);
                Test.Log(Status.Pass, "Test Pass");
            }
            catch(Exception e) {
                Test.Log(Status.Fail, "Test Fail");
                throw; }
            
        }
        [Test]
        public void VerifyErrorMessagesforEnteringIncorrectValuesInFields()
        {
            Test = null;
            Test = Extent.CreateTest("T003").Info("VerifyErrorMessagesforEnteringIncorrectValuesInFields");
            try {
                invalidRegCheck.invalidDetailsCheck();
                wait(5000);
                Test.Log(Status.Pass, "Test Pass");
            } catch (Exception e) {
                Test.Log(Status.Fail, "Test Fail");
                throw; }
            
        }
        [Test]
        public void SearchProduct()
        {
            Test = null;
            Test = Extent.CreateTest("T004").Info("SearchProduct");
            try {
                productAndFeaturesRelated.search();
                wait(5000);
                Test.Log(Status.Pass, "Test Pass");
            } catch (Exception e) {
                Test.Log(Status.Fail, "Test Fail");
                throw; }
            
        }
        [Test]
        public void EndToEndBuy()
        {
            Test = null;
            Test = Extent.CreateTest("T005").Info("EndToEndBuy");
            try {
                productAndFeaturesRelated.E2Ebuy();
                wait(5000);
                Test.Log(Status.Pass, "Test Pass");
            } catch (Exception e) {
                Test.Log(Status.Fail, "Test Fail");
                throw; }
            
        }
        [Test]
        public void AddtoCart()
        {
            Test = null;
            Test = Extent.CreateTest("T006").Info("AddtoCart");
            try {
                productAndFeaturesRelated.Addto();
                wait(5000);
                Test.Log(Status.Pass, "Test Pass");
            } catch (Exception e) {
                Test.Log(Status.Fail, "Test Fail");
                throw; }
            
        }
        [TearDown]
        public void tearDn()
        {
            Extent.Flush();
            close();
            quit();
        }
    }
}