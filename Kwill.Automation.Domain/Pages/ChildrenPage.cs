using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Kwill.Automation.Domain.Pages
{
    public class ChildrenPage
    {
        public void AddChild(IWebDriver driver)
        {
            driver.FindElement(By.Id("add-person")).Click();
        }
        public void ClickOnNext(IWebDriver driver)
        {
            driver.FindElement(By.Id("submitForm")).Click();
        }
        public void ClickOnGoBack(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-outline-dark")).Click();
        }

        public void IntroduceFirstName(IWebDriver driver, string name)
        {
            driver.FindElement(By.Id("firstName")).SendKeys(name);
        }
        public void IntroduceLastName(IWebDriver driver, string type)
        {
            driver.FindElement(By.Id("lastName")).SendKeys(type);
        }
        public void ClickOnSaveChild(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("btn-primary"))[driver.FindElements(By.ClassName("btn-primary")).Count-2].Click();
        }
        public void ClickOnCancelSaveChild(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("btn-primary"))[1].Click();
        }
        public void ClickOnEditChild(IWebDriver driver,int position)
        {
            driver.FindElements(By.ClassName("edit"))[position*2].Click();
        }
        public void ClickOnDeleteChild(IWebDriver driver, decimal position)
        {
            driver.FindElements(By.ClassName("edit"))[Decimal.ToInt32(Math.Round(position / 2))].Click();
        }
        public void ClickOnNoRemoveChild(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-info")).Click();
        }
        public void ClickOnRemoveChild(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-danger")).Click();
        }


        public void IntroduceRelationship(IWebDriver driver, string relationship)
        {
            driver.FindElement(By.Id("ddl_relationship")).SendKeys(relationship);
        }
        public void IntroduceBirthday(IWebDriver driver, string day, string month, string year)
        {
            new SelectElement(driver.FindElement(By.Id("dobDay"))).SelectByText(day);
            new SelectElement(driver.FindElement(By.Id("dobMonth"))).SelectByText(month);
            new SelectElement(driver.FindElement(By.Id("dobYear"))).SelectByText(year);
        }

        public void IntroducePostcode(IWebDriver driver, string postcode)
        {
            driver.FindElement(By.Id("CurrentAddress")).SendKeys(postcode);
        }
        public void IntroduceNumber(IWebDriver driver, string number)
        {
            driver.FindElement(By.Id("Number")).SendKeys(number);
        }
        public void IntroduceStreet(IWebDriver driver, string street)
        {
            driver.FindElement(By.Id("Street")).SendKeys(street);
        }
        public void IntroduceTown(IWebDriver driver, string village)
        {
            driver.FindElement(By.Id("Village")).SendKeys(village);
        }
        public void IntroduceCity(IWebDriver driver, string city)
        {
            driver.FindElement(By.Id("City")).SendKeys(city);
        }

        internal void IntroduceName(IWebDriver driver, string firstName)
        {
            throw new NotImplementedException();
        }
    }
}
