using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnupPortal.Pages
{
    public class TimeandMaterialPage
    {
       // private readonly By CodeTextboxlocator = By.Id("Code");
       // IWebElement? CodeTextbox;
        public void TimeandMaterialCreaterecord(IWebDriver driver)
        {
            // Create time and material for turn up portal//

            IWebElement CreateNewButtonclick = driver.FindElement(By.XPath("//*[contains(text(),'Create New')]"));
            CreateNewButtonclick.Click();
            IWebElement ClickMaterialDropdown = driver.FindElement(By.XPath("//span[text()='Material']"));
            ClickMaterialDropdown.Click();
            IWebElement ClicktimeselectionDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            ClicktimeselectionDropdown.Click();
            IWebElement CodeTextbox = driver.FindElement(By.Id("Code"));
            CodeTextbox.SendKeys("Testingt&m");
            IWebElement DescriptionTextbox = driver.FindElement(By.Id("Description"));
            DescriptionTextbox.SendKeys("test time&material ");
            IWebElement PriceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            PriceTextbox.SendKeys("25");
            IWebElement SaveButtonClick = driver.FindElement(By.Id("SaveButton"));
            SaveButtonClick.Click();
            Thread.Sleep(3000);
            IWebElement GotolastPageButtonClick = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            GotolastPageButtonClick.Click();


            IWebElement NewRecordCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            //if (NewRecordCode.Text.Equals("Testingt&m"))
            //{
            //    Assert.Pass("New time and material record created");
            //}
            //else
            //{
            //    Assert.Fail("New time and material record is not created");

            //}
            Thread.Sleep(3000);
            IWebElement GotolastPagetoeditClick = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            GotolastPagetoeditClick.Click();

        }
        public void TimeandMaterialEditrecord(IWebDriver driver)
        {
            //Edit time and material ///
            Thread.Sleep(5000);
            IWebElement EditButtonclick = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            EditButtonclick.Click();
            Thread.Sleep(5000);
            IWebElement EditMaterialDropdown = driver.FindElement(By.XPath("//span[contains(text(),'Time')]"));
            EditMaterialDropdown.Click();
            IWebElement EdittimeselectionDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
            EdittimeselectionDropdown.Click();
            IWebElement EditCodeTextbox = driver.FindElement(By.Id("Code"));
            EditCodeTextbox.Clear();
            EditCodeTextbox.SendKeys("Testingt&m");
            IWebElement EditDescriptionTextbox = driver.FindElement(By.Id("Description"));
            EditDescriptionTextbox.Clear();
            EditDescriptionTextbox.SendKeys("testing time&material editttting");
            IWebElement ClearPriceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            ClearPriceTextbox.Click();

            IWebElement EditPriceTextbox = driver.FindElement(By.Id("Price"));
            EditPriceTextbox.Clear();
            ClearPriceTextbox.Click();
            EditPriceTextbox.SendKeys("280");
            IWebElement EditSaveButtonClick = driver.FindElement(By.Id("SaveButton"));
            EditSaveButtonClick.Click();
            Thread.Sleep(5000);
            IWebElement GotoEditlastPageButtonClick = driver.FindElement(By.XPath("//span[contains(text(),'Go to last page')]"));
            GotoEditlastPageButtonClick.Click();
            Thread.Sleep(3000);
           // IWebElement EditlastDescriptionTextbox = driver.FindElement(By.XPath("//tbody/tr/tr[3]/td[3]"));
            IWebElement EditlastDescriptionTextbox = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));

            Assert.That((EditlastDescriptionTextbox.Text == "testing time&material edit"), "Time Record has not been updated");

            //EditPriceTextbox.Clear();
            //GotoEditedDescription.SendKeys("testing time&material edit");
            //if (EditlastDescriptionTextbox.Text.Equals("testing time&material edit"))
            //{
            //    Assert.Pass("time and material edited successfully");

            //}
            //else
            //{
            //    Assert.Fail("time and material not edited successfully");
            //}

            //if (GotoEditedDescription.Text.Equals("testing time&material edit"))
            //{
            //    Console.WriteLine("time and material edited successfully");

            //}
            //else
            //{
            //    Console.WriteLine("time and material not edited successfully");
            //}

        }

        public void TimeandMaterialDeleterecord(IWebDriver driver)
        {
            //Delete time and material record--//

            IWebElement DeleteButtonClk = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            DeleteButtonClk.Click();
            Thread.Sleep(3000);
            IAlert DeleteAlert = driver.SwitchTo().Alert();
            String alerttxt = DeleteAlert.Text;
            Console.WriteLine("Text from alert box---" + alerttxt);
            DeleteAlert.Accept();


        }

    }
}
