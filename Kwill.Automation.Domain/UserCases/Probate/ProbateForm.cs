using OpenQA.Selenium;

namespace Kwill.Automation.Domain.UserCases.Probate
{
    public class ProbateForm
    {
        public void SetFirstName(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("")).SendKeys("Demo");
        }
        public void SetSurName(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("")).SendKeys("Demo");
        }
        public void SetPhone(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("")).SendKeys("07700000000");
        }
        public void SetEmail(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("")).SendKeys("demo@test.com");
        }
    }
}
