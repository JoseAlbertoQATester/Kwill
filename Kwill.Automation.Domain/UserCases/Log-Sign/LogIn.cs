using OpenQA.Selenium;
using Kwill.Automation.Domain.Pages;
using Kwill.Automation.Domain.Entities;
using Kwill.Automation.Domain.Repository;

namespace Kwill.Automation.Domain.UserCases
{
    public class LogIn
    {
        LoginPage loginPage = new LoginPage();

        UserEntity userEntity = new UserEntity();

        GeneralRepository repository = new GeneralRepository();


        public string LoginCaseOK(IWebDriver driver)
        {
            userEntity = repository.GetUser("Correct");

            loginPage.AccessToLoginPage(driver);
            loginPage.IntroduceAnEmail(driver, userEntity.Email);
            loginPage.IntroduceAPassword(driver, userEntity.Password);
            loginPage.ClickOnLoginButton(driver);

            return driver.Url;
        }

        public string LoginCaseKO(IWebDriver driver)
        {
            userEntity = repository.GetUser("Correct");

            loginPage.AccessToLoginPage(driver);
            loginPage.IntroduceAnEmail(driver, userEntity.Email);
            loginPage.IntroduceAPassword(driver, userEntity.Password);
            loginPage.ClickOnLoginButton(driver);

            return driver.Url;
        }

        public string LoginCaseEmpty(IWebDriver driver)
        {
            userEntity = repository.GetUser("Correct");

            loginPage.AccessToLoginPage(driver);
            loginPage.IntroduceAnEmail(driver, userEntity.Email);
            loginPage.IntroduceAPassword(driver, userEntity.Password);
            loginPage.ClickOnLoginButton(driver);

            return driver.Url;
        }

        public string AccessToForgotPasswordPage(IWebDriver driver)
        {
            loginPage.AccessToLoginPage(driver);
            loginPage.ClickOnForgotYourPassword(driver);

            return driver.Url;
        }
    }
}
