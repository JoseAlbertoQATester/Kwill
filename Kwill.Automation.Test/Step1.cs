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
    class Step1
    {

        public LogIn login = new LogIn();

        public LogOut logout = new LogOut();

        public PersonalDetailForm  personalDetail = new PersonalDetailForm();

        public string webUrlDashboard;

        public string Username { get; private set; }

        public string PasswordOK { get; private set; }
        public string LogIn { get; private set; }

        public IWebDriver driver;


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
        [Category("Step1")]

        public void Step1EndToEndOK()
        {
            login.LoginCaseOK(driver, Username, PasswordOK);
            personalDetail.SelectEstateAccesStep1(driver);
            personalDetail.step1Customer(driver);
            personalDetail.step1Partner(driver);
            personalDetail.step1ChildrenExist(driver,0);
            personalDetail.step1AddChildren(driver);
            personalDetail.step1PetExist(driver,0);
            personalDetail.step1AddPet(driver);
        }


        [Test]
        [Category("Step1")]

        public void Step1EndNotChildrenNotPet()
        {
            login.LoginCaseOK(driver, Username, PasswordOK);
            personalDetail.SelectEstateAccesStep1(driver);
            personalDetail.step1Customer(driver);
            personalDetail.step1Partner(driver);
            personalDetail.step1ChildrenExist(driver, 1);
            personalDetail.step1PetExist(driver, 1);
        }


        [Test]
        [Category("Step1")]

        public void Step1EndNotChildren()
        {
            login.LoginCaseOK(driver, Username, PasswordOK);
            personalDetail.SelectEstateAccesStep1(driver);
            personalDetail.step1Customer(driver);
            personalDetail.step1Partner(driver);
            personalDetail.step1ChildrenExist(driver, 1);
            personalDetail.step1PetExist(driver, 0);
            personalDetail.step1AddPet(driver);
        }


        [Test]
        [Category("Step1")]

        public void Step1EndNotPet()
        {
            login.LoginCaseOK(driver, Username, PasswordOK);
            personalDetail.SelectEstateAccesStep1(driver);
            personalDetail.step1Customer(driver);
            personalDetail.step1Partner(driver);
            personalDetail.step1ChildrenExist(driver, 0);
            personalDetail.step1AddChildren(driver);
            personalDetail.step1PetExist(driver, 1);
           
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
