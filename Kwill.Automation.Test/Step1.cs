using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Kwill.Automation.Domain.UserCases;
using Kwill.Automation.Domain.Repository;
using Kwill.Automation.Domain.UserCases.FormWill;

namespace Kwill.Automation.Test
{
    class Step1
    {
        public LogIn login = new LogIn();
        public LogOut logout = new LogOut();
        public PersonalDetailForm personalDetail = new PersonalDetailForm();
        public Create_Report report = new Create_Report();

        public string Environment { get; private set; }

        public string webUrlDashboard;
        public string Username { get; private set; }
        public string PasswordOK { get; private set; }
        public string LogIn { get; private set; }
        public int counter;
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

        [Test, Order(2)]
        [Category("Step1")]
        public void Step1EndToEndOK()
        {
            login.LoginCaseOK(driver, Username, PasswordOK);
            personalDetail.SelectEstateAccesStep1(driver);
            personalDetail.step1Customer(driver, "Married");
            personalDetail.step1Partner(driver);
            personalDetail.step1ChildrenExist(driver, 0);
            personalDetail.step1AddChildren(driver);
            personalDetail.step1PetExist(driver, 0);
            personalDetail.step1AddPet(driver);
        }


        [Test,Order(1)]
        [Category("Step1")]
        
        public void Step1EndNotChildrenNotPetNotPatner()
        {
            login.LoginCaseOK(driver, Username, PasswordOK);
            personalDetail.SelectEstateAccesStep1(driver);
            personalDetail.step1Customer(driver, "Single");
            personalDetail.step1ChildrenExist(driver, 1);
            personalDetail.step1PetExist(driver, 1);
        }


        [Test, Order(3)]
        [Category("Step1")]
        public void Step1EndNotChildren()
        {
            login.LoginCaseOK(driver, Username, PasswordOK);
            personalDetail.SelectEstateAccesStep1(driver);
            personalDetail.step1Customer(driver, "Single");
            personalDetail.step1ChildrenExist(driver, 1);
            personalDetail.step1PetExist(driver, 0);
            personalDetail.step1AddPet(driver);
        }


        [Test, Order(4)]
        [Category("Step1")]
        public void Step1EndNotPet()
        {
            login.LoginCaseOK(driver, Username, PasswordOK);
            personalDetail.SelectEstateAccesStep1(driver);
            personalDetail.step1Customer(driver, "Single");
            personalDetail.step1ChildrenExist(driver, 0);
            personalDetail.step1AddChildren(driver);
            personalDetail.step1PetExist(driver, 1);
        }

       // [Test]
        [Category("Step1Stress")]
        public void Step1StressChild()
        {
            login.LoginCaseOK(driver, Username, PasswordOK);
            personalDetail.SelectEstateAccesStep1(driver);
            personalDetail.step1Customer(driver, "Single");
            counter = 0;
            personalDetail.step1ChildrenExist(driver, 0);
            while (true)
            {
                personalDetail.step1AddChildren(driver);
                counter++;
                Assert.AreEqual(driver.Url, "");

            }
        }

   //     [Test]
        [Category("Step1Stress")]
        public void Step1StressPet()
        {
            login.LoginCaseOK(driver, Username, PasswordOK);
            personalDetail.SelectEstateAccesStep1(driver);
            personalDetail.step1Customer(driver, "Single");
            counter = 0;
            personalDetail.step1ChildrenExist(driver, 0);
            personalDetail.step1AddChildren(driver);
            personalDetail.step1PetExist(driver, 0);
            while (true)
            {
                personalDetail.step1AddPet(driver);
                counter++;
                Assert.AreEqual(driver.Url, "");
            }

        }

        [TearDown]
        public void Close()
        {
            try
            {
                //    if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Passed)
                //    {
                //        driver.TakeScreenshot().SaveAsFile(TestContext.CurrentContext.Test.Name.ToString() + ".png", ScreenshotImageFormat.Png);
                //        report.CreateRepor(
                //        TestContext.CurrentContext.Test.Name,
                //        TestContext.CurrentContext.Result.Message,
                //        TestContext.CurrentContext.Test.Name.ToString() + ".png"
                //        );
                //    }

                driver.Close();
            }
            catch (Exception)
            {
                driver.Quit();
            }

        }
    }
}
