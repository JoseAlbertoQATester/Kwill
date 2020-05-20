using System;
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
    class Create
    {
        public WillEntity Will = new WillEntity();
        public CreateUser createUser = new CreateUser();
        public Repository repository = new Repository();
        public Create_Report report = new Create_Report();
        public string Username { get; private set; }
        public string PasswordOK { get; private set; }
        public IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            Username = TestContext.Parameters["user"].ToString();
            PasswordOK = TestContext.Parameters["passwordOK"].ToString();
            driver = new ChromeDriver(TestContext.Parameters["driverPath"].ToString());
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
            driver.Url = TestContext.Parameters["webUrl"].ToString();
        }

        [Test]
        [Category("Create")]

        public void RegisterNotPossible()
        {
            string result = createUser.CreateNewWillType1(driver);
            Assert.AreEqual(result, "http://beta.kwil.co.uk/Steps/Prerequisites/ThankYou");
        }


        [Test]
        [Category("Create")]
        [TestCase(0, 0)]
        
        public void RegisterPossible(int estate, int ownwerhouse)
        {
            string result = createUser.CreateNewWillType0(driver, estate, ownwerhouse);
            Assert.AreEqual(result, "http://beta.kwil.co.uk/Dashboard/Summary?nextStep=1");
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
