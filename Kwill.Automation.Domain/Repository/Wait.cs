using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Kwill.Automation.Domain.Repository
{
    public class Wait
    {
        public WebDriverWait waitToBeCliked(By by, int time, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            IWebElement firstResult = wait.Until(e => e.FindElement(by));
            return wait;
        }
    }
}
