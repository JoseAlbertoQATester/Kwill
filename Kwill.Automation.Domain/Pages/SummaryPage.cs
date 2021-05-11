using OpenQA.Selenium;

namespace Kwill.Automation.Domain.Pages
{
    class SummaryPage
    {
        public void AccessTosummaryPage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://beta.kwil.co.uk/Dashboard/Summary?isEdit=True");
        }
        public void AccessToStep1(IWebDriver driver)
        {
            driver.FindElement(By.LinkText("Edit")).Click();
        }
        public void AccessToStep2(IWebDriver driver)
        {
            driver.FindElement(By.XPath("(//a[contains(text(),'Edit')])[2]")).Click();
        }
        public void AccessToStep3(IWebDriver driver)
        {
            driver.FindElement(By.XPath("(//a[contains(text(),'Edit')])[3]")).Click();
        }
        public void AccessToStep4(IWebDriver driver)
        {
            driver.FindElement(By.XPath("(//a[contains(text(),'Edit')])[4]")).Click();
        }
        public void ClickOnViewYourWill(IWebDriver driver)
        {
            driver.FindElement(By.LinkText("View your will")).Click();
        }
        public void ClickOnLPALink(IWebDriver driver)
        {
            driver.FindElement(By.LinkText("Your LPA")).Click();
        }
        public void ClickOnEditPeopleButton(IWebDriver driver)
        {
            driver.FindElement(By.LinkText("Edit people")).Click();
        }
        public void ClickOnHelpButton(IWebDriver driver)
        {
            driver.FindElement(By.LinkText("Help")).Click();
        }
        public void ClickOnLogout(IWebDriver driver)
        {
            driver.FindElement(By.Id("logout")).Click();
        }
    }
}
