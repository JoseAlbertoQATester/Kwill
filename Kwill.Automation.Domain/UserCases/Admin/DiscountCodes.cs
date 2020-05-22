using OpenQA.Selenium;
using System;
using System.Threading;

namespace Kwill.Automation.Domain.UserCases.Admin
{
    public class DiscountCodes
    {
        public string AccesDiscountCode(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("nav-item"))[7].Click();
            return driver.Url;
        }

        public bool CreateCode(IWebDriver driver)
        {
            Thread.Sleep(1000);
            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.Id("discount-code")).SendKeys("CODE1");
            driver.FindElement(By.Id("discount-type")).SendKeys("Value");
            driver.FindElement(By.Id("discount-value")).Clear();
            driver.FindElement(By.Id("discount-value")).SendKeys("10");
            driver.FindElement(By.Id("discount-for")).SendKeys("Both");
            driver.FindElement(By.Id("discount-code")).SendKeys("");
            driver.FindElement(By.XPath("//*[@id='divIsDateActivate']/div/label[1]")).Click();
            driver.FindElement(By.Id("active-from")).SendKeys(DateTime.Today.ToString("d"));
            driver.FindElement(By.Id("active-to")).SendKeys(DateTime.Today.AddDays(1).ToString("d"));
            driver.FindElements(By.ClassName("btn-primary"))[1].Click();

            for (int i = 1; i < driver.FindElements(By.ClassName("edit")).Count+1; i++)
            {
                if (driver.FindElement(By.XPath("//*[@id='tblDiscountCode1']/tbody/tr[" + i + "]/td[1]")).Text.Contains("CODE1"))
                {
                    return true;
                }
            }
            return false;

        }

        public bool UpdateCode(IWebDriver driver)
        {
            for (int i = 1; i < driver.FindElements(By.ClassName("edit")).Count+1; i++)
            {
                if (driver.FindElement(By.XPath("//*[@id='tblDiscountCode1']/tbody/tr[" + i + "]/td[1]")).Text.Contains("CODE1"))
                {
                    driver.FindElements(By.ClassName("edit"))[i - 1].Click();
                    driver.FindElement(By.Id("discount-value")).Clear();
                    driver.FindElement(By.Id("discount-value")).SendKeys("33.33");
                    driver.FindElement(By.XPath("//*[@id='divIsDateActivate']/div/label[1]")).Click();
                    driver.FindElement(By.Id("active-from")).SendKeys(DateTime.Today.ToString("d"));
                    driver.FindElement(By.Id("active-to")).SendKeys(DateTime.Today.AddDays(1).ToString("d"));
                    driver.FindElements(By.ClassName("btn-primary"))[1].Click();
                }
            }
            return driver.FindElement(By.Id("tblDiscountCode1")).Text.Contains("33.33");
        }

        public bool DeleteCode(IWebDriver driver)
        {
            for (int i = 1; i < driver.FindElements(By.ClassName("edit")).Count+1; i++)
            {
                if (driver.FindElement(By.XPath("//*[@id='tblDiscountCode1']/tbody/tr[" + i + "]/td[1]")).Text.Contains("CODE1"))
                {
                    driver.FindElements(By.ClassName("delete"))[i-1].Click();
                    driver.FindElement(By.Id("deleteModal")).Click();
                }
             
            }
            
            return driver.FindElement(By.Id("tblDiscountCode1")).Text.Contains("CODE1");
        }


    }
}
