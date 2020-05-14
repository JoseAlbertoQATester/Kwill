using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kwill.Automation.Domain.UserCases.Dashboard
{
    class Guide
    {
        public string AccessGuidePage(IWebDriver driver)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("offer")));
            driver.FindElement(By.Id("offer")).Click();
            driver.FindElements(By.ClassName(""))[5].Click();
            return driver.Url;
        }

    }
}
