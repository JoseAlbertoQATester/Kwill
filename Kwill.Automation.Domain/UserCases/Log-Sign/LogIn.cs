using OpenQA.Selenium;
using Kwill.Automation.Domain.Entities;
using Kwill.Automation.Domain.Repository;
using System.Threading;
using reference = Kwill.Automation.Data.References.References;
using OpenQA.Selenium.Support.UI;
using System;

namespace Kwill.Automation.Domain.UserCases
{
    public class LogIn
    {
        public string LoginCaseOK(IWebDriver driver, string user, string password)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("offer")));
            driver.FindElement(By.Id("offer")).Click();
            driver.FindElements(By.ClassName("nav-link"))[4].Click();
            driver.FindElement(By.Id("Input_EmailUserName")).SendKeys(user);
            driver.FindElement(By.Id("Input_Password")).SendKeys(password);
            driver.FindElement(By.ClassName("btn-block")).Click();
            Thread.Sleep(2000);
            return driver.Url;
        }

        public string LoginCaseKO(IWebDriver driver, string user)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("offer")));
            driver.FindElement(By.Id("offer")).Click();
            driver.FindElements(By.ClassName("nav-link"))[4].Click();
            driver.FindElement(By.Id("Input_EmailUserName")).SendKeys(user);
            driver.FindElement(By.Id("Input_Password")).SendKeys("HiWord");
            driver.FindElement(By.ClassName("btn-block")).Click();
            Thread.Sleep(2000);
            return driver.Url;
        }
    }
}
