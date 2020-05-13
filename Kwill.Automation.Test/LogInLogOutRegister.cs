using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Kwill.Automation.Domain.Entities;
using Kwill.Automation.Domain.UserCases;
using Kwill.Automation.Domain.Repository;

namespace Kwill.Automation.Test
{
    class LogInLogOutRegister
    {
        public LogIn login = new LogIn();

        public LogOut logout = new LogOut();

        public Register register = new Register();

        public string webUrlDashboard;

        public string Username { get; private set; }

        public string PasswordOK { get; private set; }
        public string LogIn { get; private set; }

        public IWebDriver driver;

        string result;


        [SetUp]
        public void Setup()
        {
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
        [Category("LogIn")]

        public void LogInTestOK()
        {
            result = login.LoginCaseOK(driver, Username, PasswordOK);
            Assert.AreEqual(webUrlDashboard, result);
        }

        [Test]
        [Category("LogIn")]

        public void LogInTestKO()
        {
            result = login.LoginCaseKO(driver, Username);
            Assert.AreNotEqual(webUrlDashboard, result);
        }
        [Test]
        [Category("LogOut")]

        public void LogOutTest()
        {
            login.LoginCaseOK(driver, Username, PasswordOK);
            result = logout.LogOutOk(driver);
            Assert.AreEqual(LogIn, result);
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
