using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Kwill.Automation.Domain.UserCases.Dashboard
{
    public class Contact
    {
        public bool ContactwithKwill(IWebDriver driver, string Environment)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("offer")));
            driver.FindElement(By.Id("offer")).Click();
            driver.FindElements(By.Id("marketing-link"))[4].Click();
            Assert.AreEqual(driver.Url, "http://" + Environment + "kwil.co.uk/contact");
            driver.FindElement(By.Id("submitButton")).Click();
            Assert.IsTrue(driver.FindElement(By.ClassName("alert-danger")).Displayed,"validation are not working correctly");
            driver.FindElement(By.Id("IsAcceptPrivacy")).Click();
            driver.FindElement(By.Id("submitButton")).Click();
            Assert.IsTrue(driver.FindElement(By.ClassName("text-danger")).Displayed,"validation are not working correctly");
            driver.FindElement(By.Id("exampleInputFName")).SendKeys("Test");
            driver.FindElement(By.Id("exampleInputLName")).SendKeys("Test");
            driver.FindElements(By.Id("exampleInputLName"))[1].SendKeys("Test@test");
            driver.FindElement(By.Id("exampleFormControlTextarea1")).SendKeys("This is a test");
            driver.FindElement(By.Id("IsAcceptPrivacy")).Click();
            driver.FindElement(By.Id("submitButton")).Click();
            Assert.IsTrue(driver.FindElement(By.ClassName("text-danger")).Displayed, "validation are not working correctly");
            driver.FindElements(By.Id("exampleInputLName"))[1].Clear();
            driver.FindElements(By.Id("exampleInputLName"))[1].SendKeys("Test@test.com");
            driver.FindElement(By.Id("IsAcceptPrivacy")).Click();
            driver.FindElement(By.Id("submitButton")).Click();
            return driver.FindElement(By.Id("successMessages")).Displayed;
        }
    }
}
