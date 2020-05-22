using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Net.Http.Headers;
using System.Threading;

namespace Kwill.Automation.Domain.UserCases.FormWill
{
    public class TrusteesAndExecutorsForm
    {
        public void NotLegalGuardianNotTrustee(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("btn-link"))[1].Click();

            driver.FindElements(By.ClassName("btn-primary"))[1].Click();

            driver.FindElement(By.Id("submitForm")).Click();

            driver.FindElement(By.Id("add-person")).Click();
            driver.FindElement(By.Id("ExecutorsInfo_Person_FirstName")).SendKeys("Paul");
            driver.FindElement(By.Id("ExecutorsInfo_Person_LastName")).SendKeys("Walker");
            driver.FindElement(By.Id("ddl_relationship")).SendKeys("Son");
            driver.FindElement(By.Id("CurrentAddress")).SendKeys("AB10 1AF");
            driver.FindElement(By.Id("Number")).SendKeys("Marischal College");
            driver.FindElement(By.Id("Street")).SendKeys("Broad Street");
            driver.FindElement(By.Id("Village")).SendKeys("Wales");
            driver.FindElement(By.Id("City")).SendKeys("ABERDEEN");

            driver.FindElement(By.Id("SaveExecutor")).Click();
            
            driver.FindElement(By.Id("submitForm")).Click();

        }

        public void LegalGuardianAndTrustee(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("btn-link"))[1].Click();

            //Legal guarduian By child
            Thread.Sleep(1000);
            driver.FindElement(By.Id("add-person")).Click();
            driver.FindElement(By.Id("PersonsInfo_FirstName")).SendKeys("Paul");
            driver.FindElement(By.Id("PersonsInfo_LastName")).SendKeys("Walker");
            driver.FindElement(By.Id("ddl_relationship")).SendKeys("Brother");
            driver.FindElement(By.Id("CurrentAddress")).SendKeys("AB10 1AF");
            driver.FindElement(By.Id("PersonsInfo_Address_Number")).SendKeys("Marischal College");
            driver.FindElement(By.Id("PersonsInfo_Address_Street")).SendKeys("Broad Street");
            driver.FindElement(By.Id("PersonsInfo_Address_Village")).SendKeys("Wales");
            driver.FindElement(By.Id("PersonsInfo_Address_City")).SendKeys("ABERDEEN");

            driver.FindElement(By.Id("SavePerson")).Click();

            driver.FindElement(By.Id("submitForm")).Click();

            //Legal guardian by pet
            Thread.Sleep(1000);
            driver.FindElement(By.Id("add-person")).Click();
            driver.FindElement(By.Id("PersonsInfo_FirstName")).SendKeys("Jonh");
            driver.FindElement(By.Id("PersonsInfo_LastName")).SendKeys("Conneor");
            driver.FindElement(By.Id("ddl_relationship")).SendKeys("Friend");
            driver.FindElement(By.Id("CurrentAddress")).SendKeys("FK10 1AA");
            driver.FindElement(By.Id("PersonsInfo_Address_Number")).SendKeys("2");
            driver.FindElement(By.Id("PersonsInfo_Address_Street")).SendKeys("Mar Place");
            driver.FindElement(By.Id("PersonsInfo_Address_Village")).SendKeys("England");
            driver.FindElement(By.Id("PersonsInfo_Address_City")).SendKeys("ALLOA");

            driver.FindElement(By.Id("SavePerson")).Click();

            driver.FindElement(By.Id("submitForm")).Click();

            //Have a trustees

            driver.FindElements(By.ClassName("btn-primary"))[0].Click();

            //Add Trustees 
            Thread.Sleep(1000);
            driver.FindElement(By.Id("add-person")).Click();
            driver.FindElement(By.Id("PersonsInfo_FirstName")).SendKeys("Anne");
            driver.FindElement(By.Id("PersonsInfo_LastName")).SendKeys("Waltfor");
            driver.FindElement(By.Id("ddl_relationship")).SendKeys("Sister");
            driver.FindElement(By.Id("CurrentAddress")).SendKeys("AB10 1AF");
            driver.FindElement(By.Id("PersonsInfo_Address_Number")).SendKeys("Marischal College");
            driver.FindElement(By.Id("PersonsInfo_Address_Street")).SendKeys("Broad Street");
            driver.FindElement(By.Id("PersonsInfo_Address_Village")).SendKeys("Wales");
            driver.FindElement(By.Id("PersonsInfo_Address_City")).SendKeys("ABERDEEN");

            driver.FindElement(By.Id("SavePerson")).Click();

            Thread.Sleep(1000);
            driver.FindElement(By.Id("add-person")).Click();
            driver.FindElement(By.Id("PersonsInfo_FirstName")).SendKeys("Paul");
            driver.FindElement(By.Id("PersonsInfo_LastName")).SendKeys("Walker");
            driver.FindElement(By.Id("ddl_relationship")).SendKeys("Son");
            driver.FindElement(By.Id("CurrentAddress")).SendKeys("AB10 1AF");
            driver.FindElement(By.Id("PersonsInfo_Address_Number")).SendKeys("Marischal College");
            driver.FindElement(By.Id("PersonsInfo_Address_Street")).SendKeys("Broad Street");
            driver.FindElement(By.Id("PersonsInfo_Address_Village")).SendKeys("Wales");
            driver.FindElement(By.Id("PersonsInfo_Address_City")).SendKeys("ABERDEEN");

            driver.FindElement(By.Id("SavePerson")).Click();

            driver.FindElement(By.Id("submitForm")).Click();

            //Have a Executor

            driver.FindElement(By.Id("submitForm")).Click();

            //Add Executor
            Thread.Sleep(1000);
            driver.FindElement(By.Id("add-person")).Click();
            driver.FindElement(By.Id("ExecutorsInfo_Person_FirstName")).SendKeys("Paul");
            driver.FindElement(By.Id("ExecutorsInfo_Person_LastName")).SendKeys("Walker");
            driver.FindElement(By.Id("ddl_relationship")).SendKeys("Son");
            driver.FindElement(By.Id("CurrentAddress")).SendKeys("AB10 1AF");
            driver.FindElement(By.Id("Number")).SendKeys("Marischal College");
            driver.FindElement(By.Id("Street")).SendKeys("Broad Street");
            driver.FindElement(By.Id("Village")).SendKeys("Wales");
            driver.FindElement(By.Id("City")).SendKeys("ABERDEEN");

            driver.FindElements(By.Id("informRadioButton"))[0].Click();

            driver.FindElement(By.Id("email")).SendKeys("tester@test.com");
            driver.FindElement(By.Id("telephone")).SendKeys("66466425");

            driver.FindElement(By.Id("SaveExecutor")).Click();


            driver.FindElement(By.Id("submitForm")).Click();

        }
    }
}
