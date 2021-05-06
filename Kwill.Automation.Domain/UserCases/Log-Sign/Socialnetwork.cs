using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kwill.Automation.Domain.UserCases.Log_Sign
{
    public class Socialnetwork
    {

        public string selecgooglecount(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("BHzsHc")).Click();
            driver.FindElement(By.ClassName("zHQkBf")).SendKeys("testervisualstudio@gmail.com");
            driver.FindElement(By.ClassName("VfPpkd-RLmnJb")).Click();
            driver.FindElement(By.ClassName(" zHQkBf")).SendKeys("1234rgH!");
            driver.FindElement(By.ClassName("BHzsHc")).Click();
            driver.FindElement(By.ClassName("BHzsHc")).Click();
            return driver.Url;
        }

    }
}
