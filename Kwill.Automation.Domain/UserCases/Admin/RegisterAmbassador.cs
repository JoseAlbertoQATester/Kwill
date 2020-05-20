using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kwill.Automation.Domain.UserCases.Admin
{
    public class RegisterAmbassador
    {
        public string AccesRegisterAmbassador(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("nav-item"))[1].Click();
            return driver.Url;
        }


    }
}
