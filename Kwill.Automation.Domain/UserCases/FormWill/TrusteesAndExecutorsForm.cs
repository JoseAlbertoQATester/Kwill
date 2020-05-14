using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kwill.Automation.Domain.UserCases.FormWill
{
    public class TrusteesAndExecutorsForm
    {
        public void SelectEstateAccesStep2(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("btn-link"))[1].Click();
        }

    }
}
