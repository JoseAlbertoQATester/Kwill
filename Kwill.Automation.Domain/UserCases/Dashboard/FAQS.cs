using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Kwill.Automation.Domain.UserCases.Dashboard
{
    public class FAQS
    {
        public bool AccessFAQSPage(IWebDriver driver, string Environment)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("offer")));
            driver.FindElement(By.Id("offer")).Click();
            driver.FindElements(By.Id("marketing-link"))[2].Click();
            Assert.AreEqual(driver.Url, "http://" + Environment + "kwil.co.uk/FAQ", "Acces to incorrect page");

            for (int i = 0; i < driver.FindElements(By.ClassName("fa-plus")).Count; i++)
            {
                Thread.Sleep(500);
                driver.FindElements(By.ClassName("fa-plus"))[i].Click();
                
            }

            return driver.FindElements(By.ClassName("fa-plus")).Count.Equals(driver.FindElements(By.ClassName("panel-body")).Count);
            
        }

    }
}
