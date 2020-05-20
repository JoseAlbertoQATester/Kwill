using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kwill.Automation.Domain.UserCases.Admin
{
    public class Dashboard
    {
        DateTime DateTimeNew;
        readonly DateTime DateTime1 = new DateTime(8, 5, 2020);
        readonly DateTime DateTime2 = new DateTime(10, 5, 2020);
        public string AccesDashBoard(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("nav-item"))[0].Click();
            return driver.Url;
        }

        public bool Datafilter(IWebDriver driver)
        {
            driver.FindElement(By.Id("DateMenu")).SendKeys("5");
            driver.FindElement(By.Id("startDate")).SendKeys("08/05/2020");
            driver.FindElement(By.Id("endDate")).SendKeys("08/10/2020");
            driver.FindElement(By.Id("submitButton")).Click();
            DateTimeNew = DateTime.Parse(driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[3]/div/div[2]/div/div/div/div[5]/div[2]/table/tbody/tr[1]/td[4]")).Text);
            driver.FindElement(By.Id("siteVisitorId")).Click();
            return DateTime1.CompareTo(DateTimeNew) * DateTime2.CompareTo(DateTimeNew) > 0;
        }

        public void AcesssiteVisitor(IWebDriver driver)
        {
            driver.FindElement(By.Id("siteVisitorId")).Click();
        }
        public void AcessSignUp(IWebDriver driver)
        {
            driver.FindElement(By.Id("signUpsId")).Click();

        }
        public void AcessPurchase(IWebDriver driver)
        {
            driver.FindElement(By.Id("purchaseId")).Click();
        }


    }
}
