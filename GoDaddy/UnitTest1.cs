using NUnit.Framework;
using TestLib;
namespace GoDaddy
{
    public class Tests:BaseMethods
    {
        [SetUp]
        public void Setup()
        {
            driverInitializer();
            GoToURL("https://www.godaddy.com/");
        }

        [Test]
        public void Test1()
        {
            
        }
        [TearDown]
        public void tearDn()
        {
            wait(5000);
            close();
            quit();
        }
    }
}