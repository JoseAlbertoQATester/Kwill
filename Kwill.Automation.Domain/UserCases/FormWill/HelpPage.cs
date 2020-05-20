using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kwill.Automation.Domain.UserCases
{
    public class HelpPage
    {

        public string AccesHelpPageSummary(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-primary")).Click();
            return driver.Url;
        }

        public string AccesHelpPageNavbar(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("nav-item"))[1].Click();
            return driver.Url;
        }

        public string ViewGuide(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-primary")).Click();
            return driver.Url;
        }
    }
}
