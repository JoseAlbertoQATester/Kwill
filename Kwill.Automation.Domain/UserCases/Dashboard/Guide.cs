using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Kwill.Automation.Domain.UserCases.Dashboard
{
    public class Guide
    {
        public string GetGuide(IWebDriver driver, string Environment)
        {
            driver.FindElement(By.ClassName("navbar-brand")).Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("offer")));
            Thread.Sleep(500);
            driver.FindElement(By.Id("offer")).Click();

            Thread.Sleep(500);

            driver.FindElements(By.Id("marketing-link"))[5].Click();
            Assert.AreEqual(driver.Url, "http://" + Environment + "kwil.co.uk/guide", "Page displayed is not correct");

            driver.FindElements(By.ClassName("btn-primary"))[1].Click();
            Thread.Sleep(500);
            return driver.Url;

        }

    }
}
