using OpenQA.Selenium;

namespace Kwill.Automation.Domain.Pages
{
    class ChildrenExistingPage
    {
        public void ClickOnYes(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-primary")).Click();
        }
        public void ClickOnNo(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("btn-primary"))[1].Click();
        }
        public void ClickOnGoBack(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-outline-dark")).Click();
        }
        public void ClickOnRemoveChild(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-info")).Click();
        }
        public void ClickOnNoRemoveChild(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-danger")).Click();
        }
    }
}
