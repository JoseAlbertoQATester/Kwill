using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kwill.Automation.Domain.Pages
{
    class ChildrenPage
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

        public void IntroduceName(IWebDriver driver, string name)
        {
            driver.FindElement(By.Id("firstName")).SendKeys(name);
        }
        public void IntroduceType(IWebDriver driver, string type)
        {
            driver.FindElement(By.Id("lastName")).SendKeys(type);
        }
        public void ClickOnSaveChild(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("btn-primary"))[0].Click();
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
    }
}
