using OpenQA.Selenium;

namespace Kwill.Automation.Domain.UserCases.Probate
{
    public class ProbatePages
    {
        public void accessToProbatePage(IWebDriver driver)
        {
            driver.Url = "https://beta.kwil.co.uk/Probate";
        }

        public void ClickOnGoProbateButton(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-kwil")).Click();
        }
    }
}
