using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Kwill.Automation.Domain.Entities;
using Kwill.Automation.Domain.UserCases;
using Kwill.Automation.Domain.Repository;
using Kwill.Automation.Domain.UserCases.FormWill;
using OpenQA.Selenium.Support.Extensions;
using NUnit.Framework.Interfaces;

namespace Kwill.Automation.Test
{
    class LiveChat
    {
        public LogIn login = new LogIn();
        public LogOut logout = new LogOut();
        public Register register = new Register();
        public Livechat livechat = new Livechat();
        public Create_Report report = new Create_Report();

        public string Environment { get; private set; }

        public string webUrlDashboard;

        public string Username { get; private set; }

        public string PasswordOK { get; private set; }

        public string LogIn { get; private set; }

        public IWebDriver driver;



        [SetUp]
        public void Setup()
        {
            Environment = TestContext.Parameters["environment"].ToString();
            webUrlDashboard = TestContext.Parameters["DashBoard"].ToString();
            Username = TestContext.Parameters["user"].ToString();
            PasswordOK = TestContext.Parameters["passwordOK"].ToString();
            LogIn = TestContext.Parameters["webUrl"].ToString();
            driver = new ChromeDriver(TestContext.Parameters["driverPath"].ToString());
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
            driver.Url = LogIn;
        }

       //[Test]
        [Category("LiveChat")]
        public void Review_UseLiveChat()
        {
            login.LoginCaseOK(driver, Username, PasswordOK);
            bool result = livechat.OpenLiveChat(driver);
            Assert.IsTrue(result,"LiveChat is not open");
            string text = livechat.WriterLiveChat(driver);
            Assert.AreEqual("Hellow!", text, "the text sent is not the same as the text displayed");
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