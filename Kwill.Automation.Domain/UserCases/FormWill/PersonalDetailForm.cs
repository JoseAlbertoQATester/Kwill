using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PunditLeagueAutomation.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kwill.Automation.Domain.UserCases.FormWill
{
    class PersonalDetailForm
    {
        readonly Generator generator = new Generator();
        string name;
        public string step1Customer(IWebDriver driver)
        {
            name = generator.GeneratorString();
        
            driver.FindElement(By.Id("CustomerInfo_FirstName")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_MiddleName")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_LastName")).SendKeys(name);

            IWebElement maritalstatus = driver.FindElement(By.Id("ddl_maritalstatus"));
            SelectElement selectElement = new SelectElement(maritalstatus);
            selectElement.SelectByValue("Married"); 

            IWebElement day = driver.FindElement(By.Id("CustomerInfo_DateOfBirth_Day"));
            SelectElement dayselect = new SelectElement(day);
            dayselect.SelectByValue("1"); 

            IWebElement moth = driver.FindElement(By.Id("CustomerInfo_DateOfBirth_Month"));
            SelectElement mothselect = new SelectElement(moth);
            mothselect.SelectByValue("1");

            IWebElement year = driver.FindElement(By.Id("ddl_maritalstatus"));
            SelectElement yearselect = new SelectElement(year);
            yearselect.SelectByValue("1995");
            
            driver.FindElement(By.Id("CurrentAddress")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Address_Number")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Address_Street")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Address_Village")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Address_City")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Telephone")).SendKeys(name);
            driver.FindElement(By.Id("submitForm")).Click();
         
            
        }

        public string step1Partner(IWebDriver driver)
        {
            name = generator.GeneratorString();

            driver.FindElement(By.Id("CustomerInfo_FirstName")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_MiddleName")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_LastName")).SendKeys(name);

            IWebElement maritalstatus = driver.FindElement(By.Id("ddl_maritalstatus"));
            SelectElement selectElement = new SelectElement(maritalstatus);
            selectElement.SelectByValue("Married");

            IWebElement day = driver.FindElement(By.Id("CustomerInfo_DateOfBirth_Day"));
            SelectElement dayselect = new SelectElement(day);
            dayselect.SelectByValue("1");

            IWebElement moth = driver.FindElement(By.Id("CustomerInfo_DateOfBirth_Month"));
            SelectElement mothselect = new SelectElement(moth);
            mothselect.SelectByValue("1");

            IWebElement year = driver.FindElement(By.Id("ddl_maritalstatus"));
            SelectElement yearselect = new SelectElement(year);
            yearselect.SelectByValue("1995");

            driver.FindElement(By.Id("CurrentAddress")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Address_Number")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Address_Street")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Address_Village")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Address_City")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Telephone")).SendKeys(name);
            driver.FindElement(By.Id("submitForm")).Click();

            return driver.Url;
        }
    }
}
