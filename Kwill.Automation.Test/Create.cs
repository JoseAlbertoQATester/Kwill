using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Kwill.Automation.Domain.Entities;
using Kwill.Automation.Domain.UserCases;
using Kwill.Automation.Domain.Repository;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Support.Extensions;
using Kwill.Automation.Domain.UserCases.Log_Sign;

namespace Kwill.Automation.Test
{
    class Create
    {
        public WillEntity Will = new WillEntity();
        public CreateUser createUser = new CreateUser();
        public GeneralRepository repository = new GeneralRepository();
        //public Create_Report report = new Create_Report();
        public Socialnetwork Socialnetwork = new Socialnetwork();
        public string Environment { get; private set; }
        public string Username { get; private set; }
        public string PasswordOK { get; private set; }
        public string result;
        public int count;
        public IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            Environment = TestContext.Parameters["environment"].ToString();
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
            result = createUser.CreateNewWillType1(driver);
            Assert.AreEqual(result, "http://" + Environment + "kwil.co.uk/Steps/Prerequisites/ThankYou", "Page displayed is incorrect");
        }


        [Test]
        [Category("Create")]

        public void RegisterPossibleOwner()
        {
            result = createUser.CreateNewWillType0(driver, 0);
            Assert.AreEqual(result, "http://" + Environment + "kwil.co.uk/Dashboard/Summary?nextStep=1", "Page displayed is incorrect");
            count = createUser.ValidateBeginbuttonStart(driver);
            Assert.AreEqual(count, 6,"All step are not in begin state");
            result = createUser.ValidateOwnerpage(driver);
            Assert.AreEqual(result, "http://" + Environment + "kwil.co.uk/Steps/AccountProperties/PropertyValue", "Page displayed is incorrect");
        }

        [Test]
        [Category("Create")]
        public void RegisterPossibleNotOwner()
        {
            result = createUser.CreateNewWillType0(driver, 1);
            Assert.AreEqual(result, "http://" + Environment + "kwil.co.uk/Dashboard/Summary?nextStep=1", "Page displayed is incorrect");
            count = createUser.ValidateBeginbuttonStart(driver);
            Assert.AreEqual(count, 6, "All step are not in begin state");
            result = createUser.ValidateOwnerpage(driver);
            Assert.AreEqual(result, "http://" + Environment + "kwil.co.uk/Steps/AccountProperties/AccountProperties", "Page displayed is incorrect");
        }


        [Test]
        [Category("Create")]
        public void RegisterPossibleGoogle()
        {
            result = createUser.CreateNewWillTypeGoogle(driver);
            Assert.IsTrue (result.Contains("https://accounts.google.com/signin"));
            Assert.IsFalse(result.Contains("error"));
            result = Socialnetwork.selecgooglecount(driver);
            Assert.IsTrue(result.Contains("https://accounts.google.com/signin"));
            Assert.IsFalse(result.Contains("error"));
            count = createUser.ValidateBeginbuttonStart(driver);
            Assert.AreEqual(count, 6, "All step are not in begin state");
            result = createUser.ValidateOwnerpage(driver);
            Assert.AreEqual(result, "http://" + Environment + "kwil.co.uk/Steps/AccountProperties/AccountProperties", "Page displayed is incorrect");
        }

        [Test]
        [Category("Create")]
        public void RegisterPossibleFacebook()
        {
            result = createUser.CreateNewWillTypeFacebook(driver);
            Assert.IsTrue(result.Contains("https://www.facebook.com/login"));
            Assert.IsFalse(result.Contains("error"));

            count = createUser.ValidateBeginbuttonStart(driver);
            Assert.AreEqual(count, 6, "All step are not in begin state");
            result = createUser.ValidateOwnerpage(driver);
            Assert.AreEqual(result, "http://" + Environment + "kwil.co.uk/Steps/AccountProperties/AccountProperties", "Page displayed is incorrect");
        }

        [TearDown]
        public void Close()
        {
            try
            {
                if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Passed)
                {
                    driver.TakeScreenshot().SaveAsFile(TestContext.CurrentContext.Test.Name.ToString() + ".png", ScreenshotImageFormat.Png);
                    //report.CreateRepor(
                    //TestContext.CurrentContext.Test.Name,
                    //TestContext.CurrentContext.Result.Message,
                    //TestContext.CurrentContext.Test.Name.ToString() + ".png"
                    //);
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
