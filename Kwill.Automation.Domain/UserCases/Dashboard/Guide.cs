using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Kwill.Automation.Domain.UserCases.Dashboard
{
    public class Guide
    {
        public string GetGuide(IWebDriver driver)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("offer")));
            driver.FindElement(By.Id("offer")).Click();
            driver.FindElements(By.Id("marketing-link"))[5].Click();
            Assert.AreEqual(driver.Url, "http://beta.kwil.co.uk/contact","Page displayed is not correct");
            driver.FindElement(By.ClassName("btn-primary")).Click();
            return driver.Url;


            //driver.FindElement(By.Id("submitButton")).Click();
            //Assert.IsTrue(driver.FindElement(By.ClassName("alert-danger")).Displayed, "validation are not working correctly");

            //driver.FindElement(By.Id("IsAcceptPrivacy")).Click();
            //driver.FindElement(By.Id("submitButton")).Click();
            //Assert.IsTrue(driver.FindElement(By.ClassName("alert-danger")).Displayed, "validation are not working correctly");

            //driver.FindElement(By.Id("IsAcceptPrivacy")).SendKeys("Test");
            //driver.FindElement(By.Id("IsAcceptPrivacy")).SendKeys("Test");
            //driver.FindElement(By.Id("IsAcceptPrivacy")).SendKeys("Test@test");
            //driver.FindElement(By.Id("LeadsInfo_Mobile")).SendKeys("test");
            //driver.FindElement(By.Id("IsAcceptPrivacy")).Click();

            //Assert.IsTrue(driver.FindElement(By.ClassName("alert-danger")).Displayed, "validation email is not working correctly");

            //driver.FindElement(By.Id("LeadsInfo_Email")).Clear();
            //driver.FindElement(By.Id("LeadsInfo_Email")).SendKeys("test@test.com");
            //driver.FindElement(By.Id("LeadsInfo_Mobile")).Clear();
            //driver.FindElement(By.Id("LeadsInfo_Mobile")).SendKeys("66666666");
            //driver.FindElement(By.Id("submitButton")).Click();

            //return driver.FindElement(By.ClassName("successMessages")).Displayed;
        }

    }
}
