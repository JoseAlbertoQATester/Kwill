using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Kwill.Automation.Domain.UserCases.Dashboard
{
    public class Contact
    {
        public bool ContactwithKwill(IWebDriver driver)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("offer")));
            driver.FindElement(By.Id("offer")).Click();
            driver.FindElements(By.Id("marketing-link"))[4].Click();
            Assert.AreEqual(driver.Url, "http://beta.kwil.co.uk/contact");
            driver.FindElement(By.Id("submitButton")).Click();
            Assert.IsTrue(driver.FindElement(By.ClassName("alert-danger")).Displayed,"validation are not working correctly");
            driver.FindElement(By.Id("IsAcceptPrivacy")).Click();
            Assert.IsTrue(driver.FindElement(By.ClassName("alert-danger")).Displayed,"validation are not working correctly");
            driver.FindElement(By.Id("exampleInputFName")).SendKeys("Test");
            driver.FindElement(By.Id("exampleInputLName")).SendKeys("Test");
            driver.FindElement(By.Id("exampleInputLName")).SendKeys("Test@test");
            driver.FindElement(By.Id("exampleFormControlTextarea1")).SendKeys("This is a test");
            Assert.IsTrue(driver.FindElement(By.ClassName("alert-danger")).Displayed, "validation email is not working correctly");
            driver.FindElement(By.Id("IsAcceptPrivacy")).Clear();
            driver.FindElement(By.Id("IsAcceptPrivacy")).SendKeys("Test@test.com");
            return driver.FindElement(By.ClassName("successMessages")).Displayed;
        }
    }
}
