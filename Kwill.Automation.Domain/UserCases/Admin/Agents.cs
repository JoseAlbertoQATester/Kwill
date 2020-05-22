using OpenQA.Selenium;
using System;
using System.Threading;

namespace Kwill.Automation.Domain.UserCases.Admin
{
    public class Agents
    {

        public string AccesAgent(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("nav-item"))[11].Click();
            Thread.Sleep(500);
            return driver.Url;
        }

        public bool CreateAgent(IWebDriver driver)
        {
            Thread.Sleep(1000);
            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.Id("FirstName")).SendKeys("Stephen");
            driver.FindElement(By.Id("LastName")).SendKeys("William");
            driver.FindElement(By.Id("Email")).SendKeys("Stephen@Kwill.com");
            driver.FindElement(By.Id("EventColor")).SendKeys("#0e4313");
            driver.FindElement(By.Id("Password")).SendKeys("123456");
            driver.FindElement(By.Id("ConfirmPassword")).SendKeys("123456");

            driver.FindElements(By.ClassName("btn-primary"))[1].Click();

            for (int i = 1; i < driver.FindElements(By.ClassName("edit")).Count+1; i++)
            {
                if (driver.FindElement(By.XPath("//*[@id='tblAgent']/tbody/tr[" + i + "]/td[1]")).Text.Contains("Stephen"))
                {
                    return true;
                }
            }
            return false;

        }

        public bool UpdateAgent(IWebDriver driver)
        {
            for (int i = 1; i < driver.FindElements(By.ClassName("edit")).Count+1; i++)
            {
                if (driver.FindElement(By.XPath("//*[@id='tblAgent']/tbody/tr[" + i + "]/td[1]")).Text.Contains("Stephen"))
                {
                    driver.FindElements(By.ClassName("edit"))[i - 1].Click();
                    driver.FindElement(By.Id("EmailEdit")).Clear();
                    driver.FindElement(By.Id("EventColorEdit")).Clear();
                    driver.FindElement(By.Id("EmailEdit")).SendKeys("Stephen@Kwill.co.uk");
                    driver.FindElement(By.Id("EventColorEdit")).SendKeys("#0e4313");

                    driver.FindElements(By.Id("submitButton"))[1].Click();
                    
                }
            }
            return driver.FindElement(By.Id("tblAgent")).Text.Contains("Stephen@Kwill.co.uk");
        }

        public bool DeleteAgent(IWebDriver driver)
        {
            for (int i = 1; i < driver.FindElements(By.ClassName("edit")).Count+1; i++)
            {
                if (driver.FindElement(By.XPath("//*[@id='tblAgent']/tbody/tr[" + i + "]/td[1]")).Text.Contains("Stephen"))
                {
                    driver.FindElements(By.ClassName("delete"))[i - 1].Click();
                    driver.FindElement(By.Id("deleteModal")).Click();
                    
                }
            }
            Thread.Sleep(1000);
            return driver.FindElement(By.Id("tblAgent")).Text.Contains("Stephen");
        }
    }
}
