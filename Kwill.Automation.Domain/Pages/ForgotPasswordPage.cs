using OpenQA.Selenium;

namespace Kwill.Automation.Domain.Pages
{
    class ForgotPasswordPage
    {
        public void IntroduceEmail(IWebDriver driver,string email)
        {
            driver.FindElement(By.Id("Input_Email")).SendKeys(email);
        }
        public void lickOnSumitButton(IWebDriver driver)
        {
            driver.FindElement(By.Id("forgotPasswordSubmit")).Click();
        }
    }
}
