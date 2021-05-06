using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Kwill.Automation.Domain.Entities;
using Kwill.Automation.Domain.UserCases;
using Kwill.Automation.Domain.Repository;
using Kwill.Automation.Domain.UserCases.FormWill;
using PunditLeagueAutomation.Domain.Repository;
using OpenQA.Selenium.Support.Extensions;
using NUnit.Framework.Interfaces;

namespace Kwill.Automation.Test
{
    class Step3
    {

        public LogIn login = new LogIn();

        public Generator generor = new Generator();

        public GiftsAndYourEstateForm giftsAndYourEstate = new GiftsAndYourEstateForm();

        //public Create_Report report = new Create_Report();

        public string Environment { get; private set; }
        public string Username { get; private set; }
        public string PasswordOK { get; private set; }
        public string LogIn { get; private set; }

        public IWebDriver driver;

        public int result;


        [SetUp]
        public void Setup()
        {
            Environment = TestContext.Parameters["environment"].ToString();
            Username = TestContext.Parameters["user"].ToString();
            PasswordOK = TestContext.Parameters["passwordOK"].ToString();
            LogIn = TestContext.Parameters["webUrl"].ToString();
            driver = new ChromeDriver(TestContext.Parameters["driverPath"].ToString());
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
            driver.Url = LogIn;
        }

        [Test]
        [Category("Step3")]

        public void StepEndToEnd3OK()
        {
            int random = generor.GenerarNumber(0, 5);
            login.LoginCaseOK(driver, Username, PasswordOK);
            result = giftsAndYourEstate.SelectEstateAccesStep3(driver, Environment);
            Assert.AreNotEqual(result, 1, "Page displayed is incorrect");
            result = giftsAndYourEstate.SelectVoidEstate(driver);
            Assert.AreEqual(result, 1, "Validation is not displayed");
            giftsAndYourEstate.SelectEstate(driver);
            result = giftsAndYourEstate.SelectPropertyValueText(driver, Environment);
            //Assert.AreNotEqual(result, 1, "It is possible entry text value");
            Assert.AreNotEqual(result, 2, "Access to incorrect page");
            giftsAndYourEstate.SelectPropertyValue(driver);
            result = giftsAndYourEstate.SelectPerson(driver, random);
            Assert.AreEqual(result, 5 - random, "Access to incorrect page");
            result = giftsAndYourEstate.AddGiftRecipientNumber(driver, Environment);
            Assert.AreNotEqual(result, 1, "Access to incorrect page");
            Assert.AreNotEqual(result, 8, "Validation is not working correctly");
            result = giftsAndYourEstate.AddGiftRecipient(driver);
            Assert.AreNotEqual(result, 1, "Peron is not created");

        }



        [TearDown]
        public void Close()
        {
            try
            {
                //if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Passed)
                //{
                //    driver.TakeScreenshot().SaveAsFile(TestContext.CurrentContext.Test.Name.ToString() + ".png");
                //    report.CreateRepor(
                //            TestContext.CurrentContext.Test.Name.ToString(),
                //            TestContext.CurrentContext.Result.Message.ToString(),
                //            TestContext.CurrentContext.Test.Name.ToString() + ".png");
                //}

                driver.Close();
            }
            catch (Exception)
            {
                driver.Quit();
            }

        }
    }
}
