using OpenQA.Selenium;

namespace Kwill.Automation.Domain.UserCases.Admin
{
    public class ViewAffiliates
    {
        public string AccesViewAffiliate(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("nav-item"))[4].Click();
            return driver.Url;
        }

        public int FiltrerByToday(IWebDriver driver)
        {
            driver.FindElement(By.Id("DateMenu")).SendKeys("Today");
            driver.FindElement(By.Id("submitButton")).Click();
            return driver.FindElements(By.ClassName("odd")).Count; ;
        }

        public bool EditAffiliate(IWebDriver driver, string name)
        {
            driver.FindElements(By.ClassName("fa-edit"))[1].Click();
            driver.FindElement(By.Id("affiliateName")).SendKeys(name);
            driver.FindElements(By.ClassName("btn-primary"))[1].Click();
            return driver.FindElements(By.ClassName("odd")).Count.Equals(1);
        }

        public int AddNoteAffiliate(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("fa-plus"))[1].Click();
            driver.FindElement(By.Id("newNote")).SendKeys("Today send all email");
            driver.FindElements(By.ClassName("btn-primary"))[2].Click();
            return driver.FindElements(By.ClassName("fa-edit")).Count;
        }

        public int FilterByName(IWebDriver driver, string name)
        {
            driver.FindElements(By.ClassName("form-control-sm"))[1].SendKeys(name);
            return driver.FindElements(By.ClassName("odd")).Count;
        }
    }
}
