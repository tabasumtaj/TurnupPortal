using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnupPortal.Pages
{
    public class LoginPage
    {
        //private readonly By UsernameTextboxlocator = By.Id("UserName") ;
        //IWebElement usernameTextbox;
        //private readonly By PasswordTextboxlocator = By.Id("Password");
        //IWebElement PasswordTextbox;
        //private readonly By Loginbuttonlocator = By.XPath("//*[@id='loginForm']/form/div[3]/input[1]");
        //IWebElement Loginbutton;
        private readonly By usernameTextboxLocator = By.Id("UserName");
        IWebElement? usernameTextbox;
        private readonly By passwordTextboxLocator = By.Id("Password");
        IWebElement? passwordTextbox;
        private readonly By loginButtonLocator = By.XPath("//*[@id='loginForm']/form/div[3]/input[1]");
        IWebElement? loginButton;

            public void LoginAction(IWebDriver driver,string username,string password)
        {

            //Launch the Turnup portal url
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            string TurnupUrl = "http://horse.industryconnect.io/";
            driver.Navigate().GoToUrl(TurnupUrl);
           

             usernameTextbox = driver.FindElement(usernameTextboxLocator);
            usernameTextbox.SendKeys(username);
            //Identify the password and enter in to text box
            passwordTextbox = driver.FindElement(passwordTextboxLocator);
            passwordTextbox.SendKeys(password);
            //Identify the login button and click
            loginButton = driver.FindElement(loginButtonLocator);
            loginButton.Click();
        }

    }
}
