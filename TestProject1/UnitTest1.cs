using AtomationP;
using NUnit.Framework;
using TestLib;
namespace TestProject1
{
    public class Tests:BaseMethods
    {
        [SetUp]
        public void Setup()
        {
            driverInitializer();
            GoToURL("http://automationpractice.com/index.php");
        }

        [Test]
        public void verifyEmailValidorNot()
        {

            invalidEmailCheck.invalidEmail("Abc");
            wait(5000);
        }
        [Test]
        public void VerifyErrorMessagesforMandatoryFields()
        {

            invalidRegCheck.invalidRegChech();
            wait(5000);
        }
        [Test]
        public void VerifyErrorMessagesforEnteringIncorrectValuesInFields()
        {
            invalidRegCheck.invalidDetailsCheck();
            wait(5000);
        }
        [Test]
        public void SearchProduct()
        {
            productAndFeaturesRelated.search();
            wait(5000);
        }
        [Test]
        public void EndToEndBuy()
        {
            productAndFeaturesRelated.E2Ebuy();
            wait(5000);
        }
        [Test]
        public void AddtoCart()
        {
            productAndFeaturesRelated.Addto();
            wait(5000);
        }
        [TearDown]
        public void tearDn()
        {
            close();
            quit();
        }
    }
}