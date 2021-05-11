using OpenQA.Selenium;

namespace Kwill.Automation.Domain.Pages
{
    public class LoginPage
    {
        public void AccessToLoginPage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://beta.kwil.co.uk/Account/Login");
        }

        public void IntroduceAnEmail(IWebDriver driver, string email)
        {
            driver.FindElement(By.Id("Input_EmailUserName")).Clear();
            driver.FindElement(By.Id("Input_EmailUserName")).SendKeys(email);
        }

        public void IntroduceAPassword(IWebDriver driver, string password)
        {
            driver.FindElement(By.Id("Input_Password")).Clear();
            driver.FindElement(By.Id("Input_Password")).SendKeys(password);
        }

        public void ClickOnRememberMe(IWebDriver driver)
        {
            driver.FindElement(By.Id("Input_RememberMe")).Click();
        }

        public void DisplayPasswordText(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("input-group-prepend")).Click();
        }

        public void ClickOnLoginButton(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-primary")).Click();
        }

        public void ClickOnForgotYourPassword(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-link")).Click();
        }
     
    }
}

