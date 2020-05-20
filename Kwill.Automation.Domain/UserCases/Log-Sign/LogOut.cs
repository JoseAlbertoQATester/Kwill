using OpenQA.Selenium;
using Kwill.Automation.Domain.Entities;
using Kwill.Automation.Domain.Repository;
using System.Threading;
using reference = Kwill.Automation.Data.References.References;

namespace Kwill.Automation.Domain.UserCases
{
    public class LogOut
    {
        public string LogOutOk(IWebDriver driver)
        {
            driver.FindElement(By.Id("logout")).Click();
            
            return driver.Url;
        }
    }
}
