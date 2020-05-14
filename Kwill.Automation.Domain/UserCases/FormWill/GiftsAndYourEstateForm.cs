using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kwill.Automation.Domain.UserCases.FormWill
{
    public class GiftsAndYourEstateForm
    {
        public string SelectEstateAccesStep3(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("btn-link"))[2].Click();
            return driver.Url;
        }

        public void SelectEstate(IWebDriver driver)
        {
            IWebElement state = driver.FindElement(By.Id("estateSelectId"));
            SelectElement stateselect = new SelectElement(state);
            stateselect.SelectByValue("2");

            driver.FindElement(By.Id("submitForm")).Click();
        }

        public int SelectVoidEstate(IWebDriver driver)
        {
            IWebElement state = driver.FindElement(By.Id("estateSelectId"));
            SelectElement stateselect = new SelectElement(state);
            stateselect.SelectByValue(string.Empty);

            driver.FindElement(By.Id("submitForm")).Click();

            return driver.FindElements(By.ClassName("text-danger")).Count;

        }

        public void SelectPropertyValue(IWebDriver driver)
        {
            driver.FindElement(By.Id("PropertyValueVM_PropertyValue")).SendKeys("10000");
            driver.FindElement(By.Id("submitForm")).Click();
        }

        public void SelectPerson(IWebDriver driver)
        {
            if (driver.FindElements(By.ClassName("btn-person")).Count > 0)
            {
                for (int i = 0; i < driver.FindElements(By.ClassName("btn-person")).Count; i++)
                {
                    driver.FindElements(By.ClassName("btn-person"))[i].Click();
                }
                driver.FindElement(By.Id("submitForm")).Click();
            }
        }

        public void AddGiftRecipient(IWebDriver driver)
        {
            driver.FindElements(By.Id("add-person"))[0].Click();
            driver.FindElement(By.Id("PersonsInfo_FirstName")).SendKeys("10000");
            driver.FindElement(By.Id("PersonsInfo_LastName")).SendKeys("10000");
            driver.FindElement(By.Id("ddl_relationship")).SendKeys("10000");
            driver.FindElement(By.Id("CurrentAddress")).SendKeys("10000");
            driver.FindElement(By.Id("PersonsInfo_Address_Number")).SendKeys("10000");
            driver.FindElement(By.Id("PersonsInfo_Address_Street")).SendKeys("10000");
            driver.FindElement(By.Id("PersonsInfo_Address_Village")).SendKeys("10000");
            driver.FindElement(By.Id("PersonsInfo_Address_City")).SendKeys("10000");
        }

        public void AddCharityGiftRecipient(IWebDriver driver)
        {

            driver.FindElements(By.Id("add-person"))[1].Click();
            driver.FindElement(By.Id("tableCharities_next")).Click();
            driver.FindElements(By.Id("add-charity"))[1].Click();
            driver.FindElements(By.ClassName("even"))[1].Click();
            driver.FindElements(By.ClassName("odd"))[1].Click();
            driver.FindElement(By.ClassName("btn-primary")).Click();
        }

        public void GiftMoney(IWebDriver driver)
        {
            driver.FindElements(By.Name("gift-type"))[1].Click();
            driver.FindElement(By.Id("GiftInfo_Description")).SendKeys("Home");
            driver.FindElement(By.Id("GiftInfo_Message")).SendKeys("Present for yoy");
            driver.FindElement(By.ClassName("btn-primary")).Click();
        }

        public void GiftPossession(IWebDriver driver)
        {
            driver.FindElements(By.Name("gift-type"))[0].Click();
            driver.FindElement(By.Id("GiftInfo_Description")).SendKeys("Home");
            driver.FindElement(By.Id("GiftInfo_Message")).SendKeys("Present for yoy");
            driver.FindElement(By.ClassName("btn-primary")).Click();
        }


        public void AddNonProvisionsPerson(IWebDriver driver)
        {
            driver.FindElements(By.Id("add-person"))[0].Click();
            driver.FindElement(By.Id("NonProvisionsInfo_Person_FirstName")).SendKeys("10000");
            driver.FindElement(By.Id("NonProvisionsInfo_LastName")).SendKeys("10000");
            driver.FindElement(By.Id("ddl_relationship")).SendKeys("10000");
            driver.FindElement(By.Id("CurrentAddress")).SendKeys("10000");
            driver.FindElement(By.Id("Number")).SendKeys("10000");
            driver.FindElement(By.Id("Street")).SendKeys("10000");
            driver.FindElement(By.Id("Village")).SendKeys("10000");
            driver.FindElement(By.Id("City")).SendKeys("10000");
        }




    }
}
