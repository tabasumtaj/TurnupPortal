using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnupPortal.Utils;

namespace TurnupPortal.Pages
{
    public class HomePage
    {
        public  void GotoHomepage(IWebDriver driver)
        {
            // Create time and material for turn up portal//
            IWebElement Admindropdown = driver.FindElement(By.XPath("//*[contains(text(),'Administration')]"));
            Admindropdown.Click();
            IWebElement TimeandMaterial = driver.FindElement(By.XPath("//*[contains(text(),'Time & Materials')]"));
            TimeandMaterial.Click();
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(3));
            //WaitUtils.withTimeout(5000, TimeUnit.MILLISECONDS);
        }
        public  void verifyloggeduser(IWebDriver driver)
        {
            //After Login to check user successfull login is done.
            IWebElement SuccessfulLogin = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            Assert.That((SuccessfulLogin.Text.Equals("Hello hari!")),"Login successfull");
            //{
            //    "Login successfull");
            //if (SuccessfulLogin.Text == "Hello hari!")
            //{
            //    Assert.Pass("Login successfull");
            //}
            //else
            //{
            //    Assert.Fail("Login Failure");
            //}
        }
    }
}
