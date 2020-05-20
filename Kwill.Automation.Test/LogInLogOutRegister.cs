﻿using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Kwill.Automation.Domain.Entities;
using Kwill.Automation.Domain.UserCases;
using Kwill.Automation.Domain.Repository;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Support.Extensions;

namespace Kwill.Automation.Test
{
    class LogInLogOutRegister
    {
        public LogIn login = new LogIn();
        public LogOut logout = new LogOut();
        public Register register = new Register();
        public Create_Report report = new Create_Report();
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

        public void Customer_LogIn_Test_OK()
        {
            result = login.LoginCaseOK(driver, Username, PasswordOK);
            Assert.AreEqual(webUrlDashboard, result);
        }

        [Test]
        [Category("LogIn")]
        public void Admin_LogIn_Test_OK()
        {
            result = login.LoginCaseOK(driver, Username, PasswordOK);
            Assert.AreEqual(webUrlDashboard, result);
        }

        [Test]
        [Category("LogIn")]
        public void Ambassador_LogIn_Test_OK()
        {
            result = login.LoginCaseOK(driver, Username, PasswordOK);
            Assert.AreEqual(webUrlDashboard, result);
        }

        [Test]
        [Category("LogIn")]
        public void Affiliate_LogIn_Test_OK()
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
                if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Passed)
                {
                    driver.TakeScreenshot().SaveAsFile(TestContext.CurrentContext.Test.Name.ToString() + ".png", ScreenshotImageFormat.Png);
                    report.CreateRepor(
                    TestContext.CurrentContext.Test.Name,
                    TestContext.CurrentContext.Result.Message,
                    TestContext.CurrentContext.Test.Name.ToString() + ".png"
                    );
                }

                driver.Close();
            }
            catch (Exception)
            {
                driver.Quit();
            }

        }
    }
}
