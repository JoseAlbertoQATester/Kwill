﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kwill.Automation.Domain.Pages
{
    class PartnerPage
    {
        public void AccessTOPage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://beta.kwil.co.uk/Steps/Partner");
        }
        public void IntroduceFirstName(IWebDriver driver, string firstname)
        {
            driver.FindElement(By.Id("firstname")).Clear();
            driver.FindElement(By.Id("firstname")).SendKeys(firstname);
        }
        public void IntroduceLastName(IWebDriver driver, string lastname)
        {
            driver.FindElement(By.Id("lastname")).Clear();
            driver.FindElement(By.Id("lastname")).SendKeys(lastname);
        }

        public void IntroduceBirthday(IWebDriver driver, string day, string month, string year)
        {
            new SelectElement(driver.FindElement(By.Id("PartnerInfo_DateOfBirth_Day"))).SelectByText(day);
            new SelectElement(driver.FindElement(By.Id("PartnerInfo_DateOfBirth_Month"))).SelectByText(month);
            new SelectElement(driver.FindElement(By.Id("PartnerInfo_DateOfBirth_Year"))).SelectByText(year);
        }

        public void IntroducePostCode(IWebDriver driver, string postcode)
        {
            driver.FindElement(By.Id("CurrentAddress")).Clear();
            driver.FindElement(By.Id("CurrentAddress")).SendKeys(postcode);
        }
        public void IntroduceNumber(IWebDriver driver, string number)
        {
            driver.FindElement(By.Id("PartnerInfo_Address_Number")).Clear();
            driver.FindElement(By.Id("PartnerInfo_Address_Number")).SendKeys(number);
        }
        public void IntroduceStreet(IWebDriver driver, string street)
        {
            driver.FindElement(By.Id("PartnerInfo_Address_Street")).Clear();
            driver.FindElement(By.Id("PartnerInfo_Address_Street")).SendKeys(street);
        }
        public void IntroduceVillage(IWebDriver driver, string Village)
        {
            driver.FindElement(By.Id("PartnerInfo_Address_Village")).Clear();
            driver.FindElement(By.Id("PartnerInfo_Address_Village")).SendKeys(Village);
        }
        public void IntroduceCity(IWebDriver driver, string City)
        {
            driver.FindElement(By.Id("PartnerInfo_Address_City")).Clear();
            driver.FindElement(By.Id("PartnerInfo_Address_City")).SendKeys(City);
        }

        public void ClickOnIsAddressSame(IWebDriver driver)
        {
            driver.FindElement(By.Id("IsAddressSame")).Click();
        }
        public void ClickOnNext(IWebDriver driver)
        {
            driver.FindElement(By.Id("submitForm")).Click();
        }

        public void ClickOnGoBack(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-outline-dark")).Click();
        }
    }
}
