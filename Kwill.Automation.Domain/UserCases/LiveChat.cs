using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kwill.Automation.Domain.UserCases.FormWill
{
    public class Livechat
    {
        public bool openLiveChat(IWebDriver driver)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.ClassName("Linkify")));
            if (driver.FindElements(By.ClassName("Linkify")).Count > 0)
            {
                driver.FindElement(By.ClassName("Linkify")).Click();
            }
            return driver.FindElement(By.Id("app-portal")).Displayed;
        }

        public string writerLiveChat(IWebDriver driver)
        {
            driver.FindElement(By.TagName("textarea")).SendKeys("Hello!");
            driver.FindElement(By.ClassName("e10ozmh72")).Click();
            return driver.FindElement(By.ClassName("Linkify")).Text;
        }
    }
}
