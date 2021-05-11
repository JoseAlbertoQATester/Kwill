using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kwill.Automation.Domain.Pages
{
    class PetsExistingPage
    {
        public void ClickOnYes(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("btn-primary"))[1].Click();
        }
        public void ClickOnNo(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("btn-primary"))[2].Click();
        }
        public void ClickOnGoBack(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-outline-dark")).Click();
        }
        public void ClickOnRemovePet(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-info")).Click();
        }
        public void ClickOnNoRemovePet(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-danger")).Click();
        }
    }
}
