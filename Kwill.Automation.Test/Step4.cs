using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Kwill.Automation.Domain.Entities;
using Kwill.Automation.Domain.UserCases;
using Kwill.Automation.Domain.Repository;
using Kwill.Automation.Domain.UserCases.FormWill;
using PunditLeagueAutomation.Domain.Repository;

namespace Kwill.Automation.Test
{
    class Step4
    {


        public LogIn login = new LogIn();

        public FuneralWishesForm funeralWishes = new FuneralWishesForm();

        public Generator generator = new Generator();

        public string webUrlDashboard;

        public string Username { get; private set; }

        public string PasswordOK { get; private set; }
        public string LogIn { get; private set; }

        public IWebDriver driver;

        public  int select;

        public int value;


        [SetUp]
        public void Setup()
        {

            select = generator.GenerarNumber(0, 2);
            webUrlDashboard = TestContext.Parameters["DashBoard"].ToString();
            Username = TestContext.Parameters["user"].ToString();
            PasswordOK = TestContext.Parameters["passwordOK"].ToString();
            LogIn = TestContext.Parameters["webUrl"].ToString();
            driver = new ChromeDriver(TestContext.Parameters["driverPath"].ToString());
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
            driver.Url = LogIn;
        }


        [Test]
        [Category("Step1")]

        public void Step4EndToEndOK()
        {
            login.LoginCaseOK(driver, Username, PasswordOK);
            funeralWishes.SelectEstateAccesStep4(driver);
            value = funeralWishes.SelectFuneralDetail(driver,select);
            Assert.AreNotEqual(value, 1, "Step Should be complet");
            Assert.AreNotEqual(value, 2, "Acces incorrect page");
            Assert.AreEqual(value, 0);
            funeralWishes.SelectEstateAccesStep4(driver);
            value =funeralWishes.viewFuneralDetail(driver,select);
            Assert.AreNotEqual(value, 4, "Acces incorrect page");
            Assert.AreNotEqual(value,3,"Step Should be complet");
            Assert.AreNotEqual(value,2,"Begin button should not be displayed");
            Assert.AreNotEqual(value,1,"Funeral detail selected is not correct");
            Assert.AreEqual(value, 0);

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
