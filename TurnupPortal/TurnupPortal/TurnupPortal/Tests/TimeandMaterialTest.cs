using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using TurnupPortal.Pages;
using TurnupPortal.Utils;

namespace TurnupPortal.Tests
{
    [TestFixture]
    public class TimeandMaterialTest: CommonDriver
    {
        TimeandMaterialPage TMObj = new TimeandMaterialPage();
        public static void Main(String[] args)
        {

            Console.WriteLine("unit time page");
        }
        [SetUp]
        public void SetupTimeandMaterial()
        {
            driver = new ChromeDriver();
            //create object for Calling the Login method//
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginAction(driver, "hari", "123123");

            //Home page object
            HomePage homepageObj = new HomePage();
            homepageObj.GotoHomepage(driver);
            homepageObj.verifyloggeduser(driver);

        }
        [Test,Order(1),Description("To test time and material record creation")]
        public void CreatetimeandmaterialTest()
        {

            TMObj.TimeandMaterialCreaterecord(driver);
        }
        [Test,Order(2),Description("To test time and material record edit")]
        public void EdittimeandmaterialTest()
        {
           
            TMObj.TimeandMaterialEditrecord(driver);
        }
        [Test, Order(3), Description("To test time and material record Delete")]
        public void DeletetimeandmaterialTest()
        {

            TMObj.TimeandMaterialDeleterecord(driver);
        }
        [TearDown]
        public void CloseTestrun()
        {
            driver.Quit();
        }

    }
}
