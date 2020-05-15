using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kwill.Automation.Domain.UserCases.FormWill
{
    public class GiftsAndYourEstateForm
    {
        public int SelectEstateAccesStep3(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("btn-link"))[2].Click();

            if (driver.Url == "http://beta.kwil.co.uk/Steps/AccountProperties/EstateValue")
            {
                return 0;
            }
            return 1;
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

        public int SelectPropertyValueText(IWebDriver driver)
        {
            if (driver.Url == "http://beta.kwil.co.uk/Steps/AccountProperties/PropertyValue")
            {
                driver.FindElement(By.Id("PropertyValueVM_PropertyValue")).SendKeys("one million-!$%,.");
                driver.FindElement(By.Id("submitForm")).Click();
                if (driver.Url == "http://beta.kwil.co.uk/Steps/AccountProperties/AccountProperties")
                {
                    driver.FindElement(By.ClassName("btn-link")).Click();
                    return 1;
                }
                return 0;
            }
            return 2;
        }

        public void SelectPropertyValue(IWebDriver driver)
        {
            driver.FindElement(By.Id("PropertyValueVM_PropertyValue")).Clear();
            driver.FindElement(By.Id("PropertyValueVM_PropertyValue")).SendKeys("10000");
            driver.FindElement(By.Id("submitForm")).Click();
        }

        public int SelectPerson(IWebDriver driver, int select)
        {
            while (driver.FindElements(By.ClassName("active")).Count != 0)
            {
                driver.FindElements(By.ClassName("active"))[0].Click();
            }

            if (driver.FindElements(By.ClassName("btn-person")).Count > 0)
            {
                for (int i = 0; i < driver.FindElements(By.ClassName("btn-person")).Count - select; i++)
                {
                    driver.FindElements(By.ClassName("btn-person"))[i].Click();
                }
                driver.FindElements(By.ClassName("btn-person"))[0].Click();
                select = driver.FindElements(By.ClassName("active")).Count;
                driver.FindElement(By.Id("submitForm")).Click();
            }
            return select;
        }

        public int AddGiftRecipientNumber(IWebDriver driver)
        {
            if (driver.Url == "http://beta.kwil.co.uk/Steps/Gifts/Gifts?nextStep=3")
            {
                driver.FindElements(By.Id("add-person"))[0].Click();
                driver.FindElement(By.Id("PersonsInfo_FirstName")).SendKeys("10000");
                driver.FindElement(By.Id("PersonsInfo_LastName")).SendKeys("10000");
                driver.FindElement(By.Id("ddl_relationship")).SendKeys("Daughter");
                driver.FindElement(By.Id("CurrentAddress")).SendKeys("10000");
                driver.FindElement(By.Id("PersonsInfo_Address_Number")).SendKeys("10000");
                driver.FindElement(By.Id("PersonsInfo_Address_Street")).SendKeys("10000");
                driver.FindElement(By.Id("PersonsInfo_Address_Village")).SendKeys("10000");
                driver.FindElement(By.Id("PersonsInfo_Address_City")).SendKeys("10000");
                driver.FindElement(By.Id("SavePerson")).Click();

                return driver.FindElements(By.ClassName("text-danger")).Count;
            }
            return 1;
        }

        public int AddGiftRecipient(IWebDriver driver)
        {
            driver.FindElements(By.Id("add-person"))[0].Click();
            driver.FindElement(By.Id("PersonsInfo_FirstName")).SendKeys("Tester");
            driver.FindElement(By.Id("PersonsInfo_LastName")).SendKeys("Test");
            driver.FindElement(By.Id("ddl_relationship")).SendKeys("1");
            driver.FindElement(By.Id("CurrentAddress")).SendKeys("AB10 1AF");
            driver.FindElement(By.Id("PersonsInfo_Address_Number")).SendKeys("Marischal College");
            driver.FindElement(By.Id("PersonsInfo_Address_Street")).SendKeys("Broad Street");
            driver.FindElement(By.Id("PersonsInfo_Address_Village")).SendKeys("UK");
            driver.FindElement(By.Id("PersonsInfo_Address_City")).SendKeys("ABERDEEN");

            driver.FindElement(By.Id("SavePerson")).Click();

            for (int i = 0; i < driver.FindElements(By.ClassName("person")).Count; i++)
            {
                if (driver.FindElements(By.ClassName("person"))[i].Text.Contains("Tester"))
                {
                    return 0;
                }
            }
            return 1;

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
