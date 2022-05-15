using NUnit.Framework;
using System;
using TestLib;
namespace LetsK
{
    public class Tests:BaseMethods
    {
        [SetUp]
        public void Setup()
        {
            driverInitializer();
            GoToURL("https://courses.letskodeit.com/practice");
        }

        [Test]
        public void radioButton()
        {
            try
            {
                Click(propertype.Xpath, "(//*[@id='radio-btn-example']//child::input)[1]");
                wait(2000);
                Click(propertype.Xpath, "(//*[@id='radio-btn-example']//child::input)[2]");
                wait(2000);
                Click(propertype.Xpath, "(//*[@id='radio-btn-example']//child::input)[3]");
            }
            catch(Exception e)
            {
                throw;
            }
        }
        [Test]
        public void selectClassExample()
        {
            try
            {
                Click(propertype.Xpath, "//*[@id='select-class-example']//child::select//option[1]");
                wait(2000);
                Click(propertype.Xpath, "//*[@id='select-class-example']//child::select//option[2]");
                wait(2000);
                Click(propertype.Xpath, "//*[@id='select-class-example']//child::select//option[3]");
                wait(2000);
            }
            catch (Exception e)
            {
                throw;
            }
        }[Test]
        public void mselectClassExample()
        {
            try
            {
                Click(propertype.Xpath, "(//*[@id='multiple-select-example']//child::option)[1]");
                wait(2000);
                Click(propertype.Xpath, "(//*[@id='multiple-select-example']//child::option)[2]");
                wait(2000);
                Click(propertype.Xpath, "(//*[@id='multiple-select-example']//child::option)[3]");
                wait(2000);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [Test]
        public void CheckBox()
        {
            try
            {
                Click(propertype.Xpath, "(//*[@id='checkbox-example-div']//child::input)[1]");
                wait(2000);
                Click(propertype.Xpath, "(//*[@id='checkbox-example-div']//child::input)[2]");
                wait(2000);
                Click(propertype.Xpath, "(//*[@id='checkbox-example-div']//child::input)[3]");
                wait(2000);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [Test]
        public void mouseHover()
        {
            try
            {
                MouseHover("//*[@id='mousehover']");
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [TearDown]
        public void tearDn()
        {
            close();
            quit();
        }
    }
}