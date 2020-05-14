using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Kwill.Automation.Domain.Entities;
using Kwill.Automation.Domain.UserCases;
using Kwill.Automation.Domain.Repository;
using Kwill.Automation.Domain.UserCases.FormWill;

namespace Kwill.Automation.Test
{
    class Step3
    {

        public LogIn login = new LogIn();

        public GiftsAndYourEstateForm giftsAndYourEstate = new GiftsAndYourEstateForm();

        public string Username { get; private set; }
        public string PasswordOK { get; private set; }
        public string LogIn { get; private set; }

        public IWebDriver driver;
        public string value;
        public int resul;


        [SetUp]
        public void Setup()
        {
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

        public void stepEndToEnd3OK()
        {
            login.LoginCaseOK(driver, Username, PasswordOK);
            value=giftsAndYourEstate.SelectEstateAccesStep3(driver);
            Assert.AreEqual(value, "http://beta.kwil.co.uk/Steps/AccountProperties/EstateValue", "PAge displayed is incorrect");
            resul = giftsAndYourEstate.SelectVoidEstate(driver);
            Assert.AreEqual(resul, 1, "Validation is not displayed");


        }

     

        [TearDown]
        public void Close()
        {
            try
            {
                driver.Close();
            }
            catch (Exception)
            {
                driver.Quit();
            }

        }
    }
}
