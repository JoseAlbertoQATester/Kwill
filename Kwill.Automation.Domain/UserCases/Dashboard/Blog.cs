using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Kwill.Automation.Domain.UserCases.Dashboard
{
    public class Blog
    {
        string  articleTitle;
        public bool AccessArticlePage(IWebDriver driver)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("offer")));
            driver.FindElement(By.Id("offer")).Click();
            driver.FindElements(By.Id("marketing-link"))[1].Click();
            Assert.AreEqual(driver.Url, "http://kwil.co.uk/Blog/Index", "Acces to incorrect page");
            articleTitle = driver.FindElements(By.ClassName("blog-cell"))[0].Text.Substring(0, driver.FindElements(By.ClassName("blog-cell"))[0].Text.IndexOf('\r'));
            driver.FindElements(By.ClassName("btn-success"))[0].Click();
            return driver.FindElement(By.ClassName("whitepad")).Text.Contains(articleTitle); ;
        }
    }
}
