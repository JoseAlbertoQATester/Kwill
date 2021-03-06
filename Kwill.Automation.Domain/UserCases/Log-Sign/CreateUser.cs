﻿using OpenQA.Selenium;
using PunditLeagueAutomation.Domain.Repository;
using OpenQA.Selenium.Support.UI;
using System;

namespace Kwill.Automation.Domain.UserCases
{
    public class CreateUser
    {
        readonly Generator generator = new Generator();
        
        string name;
        public string CreateNewWillType0(IWebDriver driver, int ownwerhouse)
        {
            name = generator.GeneratorString();
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("offer")));
            driver.FindElement(By.Id("offer")).Click();
            driver.FindElement(By.ClassName("create-will")).Click();
            driver.FindElements(By.ClassName("signup"))[0].Click();
            driver.FindElements(By.ClassName("signup"))[ownwerhouse].Click();
            driver.FindElement(By.Id("UserDetails_Name")).SendKeys(name);
            driver.FindElement(By.Id("UserDetails_Email")).SendKeys(name+"@test.com");
            driver.FindElement(By.Id("UserDetails_Password")).SendKeys("1234rgH@");
            driver.FindElement(By.Id("UserDetails_ConfirmPassword")).SendKeys("1234rgH@");
            driver.FindElement(By.Id("IsAcceptPrivacy")).Click();
            driver.FindElement(By.Id("submitButton")).Click();
            return driver.Url;
        }

        public string CreateNewWillType1(IWebDriver driver)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("offer")));
            driver.FindElement(By.Id("offer")).Click();
            driver.FindElement(By.ClassName("create-will")).Click();
            driver.FindElements(By.ClassName("signup"))[1].Click();
            driver.FindElement(By.ClassName("btn-link")).Click();
            driver.FindElements(By.ClassName("signup"))[1].Click();
            driver.FindElement(By.Id("NotPossibleInfo_FirstName")).SendKeys("Tester");
            driver.FindElement(By.Id("NotPossibleInfo_LastName")).SendKeys("Test");
            driver.FindElement(By.Id("NotPossibleInfo_Email")).SendKeys("test@test.com");
            driver.FindElement(By.Id("NotPossibleInfo_Telephone")).SendKeys("666666666");
            driver.FindElement(By.Id("IsAcceptPrivacy")).Click();
            driver.FindElement(By.Id("submitButton")).Click();
            return driver.Url;
        }

        public string ValidateOwnerpage(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("btn-primary"))[2].Click();
            driver.FindElement(By.Id("estateSelectId")).SendKeys("Under £50,000");
            driver.FindElement(By.Id("submitForm")).Click();
            
            return driver.Url;
        }

        public int ValidateBeginbuttonStart(IWebDriver driver)
        {
            return driver.FindElements(By.ClassName("btn-primary")).Count;
        }
        public string CreateNewWillTypeGoogle(IWebDriver driver)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("offer")));
            driver.FindElement(By.Id("offer")).Click();
            driver.FindElement(By.ClassName("create-will")).Click();
            driver.FindElements(By.ClassName("signup"))[0].Click();
            driver.FindElements(By.ClassName("signup"))[0].Click();
            IWebElement element = driver.FindElement(By.ClassName("abcRioButtonContentWrapper"));

            PopupWindowFinder Finder = new PopupWindowFinder(driver);
            string popupWindowHandle = Finder.Click(element);

            driver.SwitchTo().Window(popupWindowHandle);

            return driver.Url;
        }

        public string CreateNewWillTypeFacebook(IWebDriver driver)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("offer")));
            driver.FindElement(By.Id("offer")).Click();
            driver.FindElement(By.ClassName("create-will")).Click();
            driver.FindElements(By.ClassName("signup"))[0].Click();
            driver.FindElements(By.ClassName("signup"))[0].Click();
            IWebElement element = driver.FindElement(By.ClassName("fb-login-button"));

            PopupWindowFinder Finder = new PopupWindowFinder(driver);
            string popupWindowHandle = Finder.Click(element);

            driver.SwitchTo().Window(popupWindowHandle);

            return driver.Url;
        }

    }
}
