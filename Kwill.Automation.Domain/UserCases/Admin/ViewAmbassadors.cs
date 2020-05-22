using OpenQA.Selenium;

namespace Kwill.Automation.Domain.UserCases.Admin
{
    public class ViewAmbassadors
    {

        public string AccesViewAmbassador(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("nav-item"))[1].Click();
            return driver.Url;
        }

        public int FiltrerByToday (IWebDriver driver)
        {
            driver.FindElement(By.Id("DateMenu")).SendKeys("Today");
            driver.FindElement(By.Id("submitButton")).Click();
            return driver.FindElements(By.ClassName("odd")).Count; ;
        }

        public bool EditAmbassador(IWebDriver driver,int number)
        {
            driver.FindElement(By.ClassName("fa-edit")).Click();
            driver.FindElement(By.Id("newNote")).SendKeys(number.ToString());
            driver.FindElement(By.Id("btn-primary")).Click();
            return driver.FindElements(By.ClassName("odd")).Count.Equals(number.ToString());
        }

        public int AddNoteAmbassador(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("fa-plus")).Click();
            driver.FindElement(By.Id("newNote")).SendKeys("Today send all email");
            driver.FindElement(By.Id("btn-primary")).Click();
            return driver.FindElements(By.ClassName("odd")).Count; ;
        }

        public int FilterByName(IWebDriver driver,string name)
        {
            driver.FindElement(By.Id("tblViewUsers_filter")).SendKeys(name);
            return driver.FindElements(By.ClassName("odd")).Count; 
        }


    }
}
