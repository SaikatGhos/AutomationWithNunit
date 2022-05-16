using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System;
using TestLib;
namespace LetsK
{
    public class Tests:BaseMethods
    {
        public static ExtentTest Test;
        public static ExtentReports Extent;
        [SetUp]
        public void Setup()
        {
            driverInitializer();
            GoToURL("https://courses.letskodeit.com/practice");
        }
        [OneTimeSetUp]
        public void ExtentStart()
        {
            Extent = new ExtentReports();
            var HtmlReporter = new ExtentHtmlReporter(@"C:\Users\SAIKAT\source\repos\TestProject1\LetsK\" + DateTime.Now.ToString("_MMddyyyy_hhmmtt") + ".html");
            Extent.AttachReporter(HtmlReporter);
        }
        [Test]
        public void radioButton()
        {
            Test = null;
            Test = Extent.CreateTest("T001").Info("RadioButton");
            try
            {
                Click(propertype.Xpath, "(//*[@id='radio-btn-example']//child::input)[1]");
                wait(2000);
                Click(propertype.Xpath, "(//*[@id='radio-btn-example']//child::input)[2]");
                wait(2000);
                Click(propertype.Xpath, "(//*[@id='radio-btn-example']//child::input)[3]");
                Test.Log(Status.Pass, "Test Pass");
            }
            catch(Exception e)
            {
                Test.Log(Status.Fail, "Test Fail");
                throw;
            }
        }
        [Test]
        public void selectClassExample()
        {
            Test = null;
            Test = Extent.CreateTest("T002").Info("SelectClass");
            try
            {
                Click(propertype.Xpath, "//*[@id='select-class-example']//child::select//option[1]");
                wait(2000);
                Click(propertype.Xpath, "//*[@id='select-class-example']//child::select//option[2]");
                wait(2000);
                Click(propertype.Xpath, "//*[@id='select-class-example']//child::select//option[3]");
                wait(2000);
                Test.Log(Status.Pass, "Test Pass");
            }
            catch (Exception e)
            {
                Test.Log(Status.Fail, "Test Fail");
                throw;
            }
        }[Test]
        public void mselectClassExample()
        {
            Test = null;
            Test = Extent.CreateTest("T003").Info("MSelectClass");
            try
            {
                Click(propertype.Xpath, "(//*[@id='multiple-select-example']//child::option)[1]");
                wait(2000);
                Click(propertype.Xpath, "(//*[@id='multiple-select-example']//child::option)[2]");
                wait(2000);
                Click(propertype.Xpath, "(//*[@id='multiple-select-example']//child::option)[3]");
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
        public void CheckBox()
        {
            Test = null;
            Test = Extent.CreateTest("T004").Info("CheckBox");
            try
            {
                Click(propertype.Xpath, "(//*[@id='checkbox-example-div']//child::input)[1]");
                wait(2000);
                Click(propertype.Xpath, "(//*[@id='checkbox-example-div']//child::input)[2]");
                wait(2000);
                Click(propertype.Xpath, "(//*[@id='checkbox-example-div']//child::input)[3]");
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
        public void mouseHover()
        {
            Test = null;
            Test = Extent.CreateTest("T005").Info("MouseHover");
            try
            {
                MouseHover("//*[@id='mousehover']");
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
            close();
            quit();
        }
    }
}