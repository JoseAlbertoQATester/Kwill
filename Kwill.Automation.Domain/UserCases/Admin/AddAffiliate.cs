using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kwill.Automation.Domain.UserCases.Admin
{
    public class AddAffiliate
    {
        public string AccesRegisterAffiliate(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("nav-item"))[3].Click();
            return driver.Url;
           
        }

        public int RegisterEmptyAffiliate(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("nav-item"))[3].Click();
            driver.FindElement(By.Id("submitButton")).Click();
            return driver.FindElements(By.ClassName("text-danger")).Count;
            //sholud be 7
        }

        public int RegisterInvalidmbAffiliate(IWebDriver driver)
        {
            driver.FindElement(By.Id("Vm_AffiliateName")).Clear();
            driver.FindElement(By.Id("Vm_AffiliateName")).SendKeys("test");

            driver.FindElement(By.Id("Vm_DiscountType")).SendKeys("NotSet");

            driver.FindElement(By.Id("Vm_SingleWillValue")).Clear();
            driver.FindElement(By.Id("Vm_SingleWillValue")).SendKeys("test");

            driver.FindElement(By.Id("Vm_CoupleWillValue")).Clear();
            driver.FindElement(By.Id("Vm_CoupleWillValue")).SendKeys("test");

            driver.FindElement(By.Id("Vm_ContactName")).Clear();
            driver.FindElement(By.Id("Vm_ContactName")).SendKeys("1234");

            driver.FindElement(By.Id("Vm_ContactUserName")).Clear();
            driver.FindElement(By.Id("Vm_ContactUserName")).SendKeys("1234");

            driver.FindElement(By.Id("Vm_ContactEmail")).Clear();
            driver.FindElement(By.Id("Vm_ContactEmail")).SendKeys("1234@test");

            driver.FindElement(By.Id("Vm_ContactMobile")).Clear();
            driver.FindElement(By.Id("Vm_ContactMobile")).SendKeys("test");

            driver.FindElement(By.Id("Vm_Password")).Clear();
            driver.FindElement(By.Id("Vm_Password")).SendKeys("1234");

            driver.FindElement(By.Id("Vm_ConfirmPassword")).Clear();
            driver.FindElement(By.Id("Vm_ConfirmPassword")).SendKeys("123");

            driver.FindElement(By.Id("submitButton")).Click();

            return driver.FindElements(By.ClassName("text-danger")).Count;
        }

        public int RegisterCorrectAffiliate(IWebDriver driver)
        {

            driver.FindElement(By.Id("Vm_AffiliateName")).Clear();
            driver.FindElement(By.Id("Vm_AffiliateName")).SendKeys("Astrid");

            driver.FindElement(By.Id("Vm_DiscountType")).SendKeys("Value");

            driver.FindElement(By.Id("Vm_SingleWillValue")).Clear();
            driver.FindElement(By.Id("Vm_SingleWillValue")).SendKeys("10");

            driver.FindElement(By.Id("Vm_CoupleWillValue")).Clear();
            driver.FindElement(By.Id("Vm_CoupleWillValue")).SendKeys("10");

            driver.FindElement(By.Id("Vm_ContactName")).Clear();
            driver.FindElement(By.Id("Vm_ContactName")).SendKeys("Astrid");

            driver.FindElement(By.Id("Vm_ContactUserName")).Clear();
            driver.FindElement(By.Id("Vm_ContactUserName")).SendKeys("Astrid");

            driver.FindElement(By.Id("Vm_ContactEmail")).Clear();
            driver.FindElement(By.Id("Vm_ContactEmail")).SendKeys("Astrid@Kwill.co.uk");

            driver.FindElement(By.Id("Vm_ContactMobile")).Clear();
            driver.FindElement(By.Id("Vm_ContactMobile")).SendKeys("07646888844");

            driver.FindElement(By.Id("Vm_Password")).Clear();
            driver.FindElement(By.Id("Vm_Password")).SendKeys("123456");

            driver.FindElement(By.Id("Vm_ConfirmPassword")).Clear();
            driver.FindElement(By.Id("Vm_ConfirmPassword")).SendKeys("123456");

            driver.FindElement(By.Id("submitButton")).Click();

            return driver.FindElements(By.ClassName("text-danger")).Count;
        }
    }
}
