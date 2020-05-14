﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kwill.Automation.Domain.UserCases.Dashboard
{
    class Blog
    {
        public string AccessBlogPage(IWebDriver driver)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("offer")));
            driver.FindElement(By.Id("offer")).Click();
            driver.FindElements(By.ClassName(""))[1].Click();
            return driver.Url;
        }
    }
}
