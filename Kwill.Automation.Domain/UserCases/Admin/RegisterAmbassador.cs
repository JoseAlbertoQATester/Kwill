using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kwill.Automation.Domain.UserCases.Admin
{
    public class RegisterAmbassador
    {
        public string AccesRegisterAmbassador(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("nav-item"))[1].Click();
            return driver.Url;
        }

        public int RegisterEmptyAmbassador(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("nav-item"))[1].Click();
            driver.FindElement(By.Id("submitButton")).Click();
            return driver.FindElements(By.ClassName("text-danger")).Count;
        }

        public int RegisterInvalidmbassador(IWebDriver driver)
        {

            driver.FindElement(By.Id("Vm_Name")).Clear();
            driver.FindElement(By.Id("Vm_LastName")).Clear();
            driver.FindElement(By.Id("Vm_UserName")).Clear();
            driver.FindElement(By.Id("Vm_Email")).Clear();
            driver.FindElement(By.Id("Vm_AmbassadorMobile")).Clear();
            driver.FindElement(By.Id("Vm_BankName")).Clear();
            driver.FindElement(By.Id("Vm_AccountName")).Clear();
            driver.FindElement(By.Id("Vm_AccountNumber")).Clear();
            driver.FindElement(By.Id("Vm_SortCode")).Clear();
            driver.FindElement(By.Id("Vm_TownCity")).Clear();
            driver.FindElement(By.Id("Vm_Password")).Clear();
            driver.FindElement(By.Id("Vm_ConfirmPassword")).Clear();
            driver.FindElement(By.Id("Vm_Name")).SendKeys("123");
            driver.FindElement(By.Id("Vm_LastName")).SendKeys("123");
            driver.FindElement(By.Id("Vm_UserName")).SendKeys("123");
            driver.FindElement(By.Id("Vm_Email")).SendKeys("test@test");
            driver.FindElement(By.Id("Vm_AmbassadorMobile")).SendKeys("unodostres");
            driver.FindElement(By.Id("Vm_BankName")).SendKeys("123");
            driver.FindElement(By.Id("Vm_AccountName")).SendKeys("SecretNumber");
            driver.FindElement(By.Id("Vm_AccountNumber")).SendKeys("SecretNumber");
            driver.FindElement(By.Id("Vm_SortCode")).SendKeys("SecretNumber");
            driver.FindElement(By.Id("Vm_TownCity")).SendKeys("123");
            driver.FindElement(By.Id("Vm_Password")).SendKeys("123");
            driver.FindElement(By.Id("Vm_ConfirmPassword")).SendKeys("456");

            driver.FindElement(By.Id("submitButton")).Click();

            return driver.FindElements(By.ClassName("text-danger")).Count;
        }

        public int RegisterCorrectAmbassador(IWebDriver driver)
        {

            driver.FindElement(By.Id("Vm_Name")).Clear();
            driver.FindElement(By.Id("Vm_LastName")).Clear();
            driver.FindElement(By.Id("Vm_UserName")).Clear();
            driver.FindElement(By.Id("Vm_Email")).Clear();
            driver.FindElement(By.Id("Vm_AmbassadorMobile")).Clear();
            driver.FindElement(By.Id("Vm_BankName")).Clear();
            driver.FindElement(By.Id("Vm_AccountName")).Clear();
            driver.FindElement(By.Id("Vm_AccountNumber")).Clear();
            driver.FindElement(By.Id("Vm_SortCode")).Clear();
            driver.FindElement(By.Id("Vm_TownCity")).Clear();
            driver.FindElement(By.Id("Vm_Password")).Clear();
            driver.FindElement(By.Id("Vm_ConfirmPassword")).Clear();
            driver.FindElement(By.Id("Vm_Name")).SendKeys("Jonh");
            driver.FindElement(By.Id("Vm_LastName")).SendKeys("Gonzalez");
            driver.FindElement(By.Id("Vm_UserName")).SendKeys("JonhGnz");
            driver.FindElement(By.Id("Vm_Email")).SendKeys("JonhGnz@Kwill");
            driver.FindElement(By.Id("Vm_AmbassadorMobile")).SendKeys("6452137458");
            driver.FindElement(By.Id("Vm_BankName")).SendKeys("BBVA");
            driver.FindElement(By.Id("Vm_AccountName")).SendKeys("Jonh");
            driver.FindElement(By.Id("Vm_AccountNumber")).SendKeys("4444333322221111");
            driver.FindElement(By.Id("Vm_SortCode")).SendKeys("111");
            driver.FindElement(By.Id("Vm_TownCity")).SendKeys("Aberavon");
            driver.FindElement(By.Id("Vm_Password")).SendKeys("123456");
            driver.FindElement(By.Id("Vm_ConfirmPassword")).SendKeys("123456");

            driver.FindElement(By.Id("submitButton")).Click();
            return driver.FindElements(By.ClassName("text-danger")).Count;
        }




    }
}
