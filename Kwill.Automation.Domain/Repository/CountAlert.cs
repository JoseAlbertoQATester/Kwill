using OpenQA.Selenium;

namespace Kwill.Automation.Domain.Repository
{
    class CountAlert
    {
        public int CountAletInPage(IWebDriver driver)
        {
            return driver.FindElements(By.ClassName("text-danger")).Count; ;
        }

    }
}
