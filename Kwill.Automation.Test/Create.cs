using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Kwill.Automation.Domain.Entities;
using Kwill.Automation.Domain.UserCases;
using Kwill.Automation.Domain.Repository;

namespace Kwill.Automation.Test
{
    class Create
    {

        public WillEntity Will = new WillEntity();

        public CreateUser createUser = new CreateUser();

        public Repository repository = new Repository();

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
        [TestCase(1, 0)]
        [TestCase(2, 0)]
        [TestCase(3, 0)]
        [TestCase(4, 0)]
        [TestCase(5, 0)]
        [TestCase(6, 0)]
        [TestCase(7, 0)]
        [TestCase(8, 0)]
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 1)]
        [TestCase(4, 1)]
        [TestCase(5, 1)]
        [TestCase(6, 1)]
        [TestCase(7, 1)]
        [TestCase(8, 1)]
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
                driver.Close();
            }
            catch (Exception)
            {
                driver.Quit();
            }

        }
    }
}
