using Kwill.Automation.Domain.Repository;
using Kwill.Automation.Domain.UserCases;
using Kwill.Automation.Domain.UserCases.FormWill;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Kwill.Automation.Test
{
    class Pay
    {
        public CreateUser createUser = new CreateUser();

        public PersonalDetailForm step1 = new PersonalDetailForm();
        public TrusteesAndExecutorsForm step2 = new TrusteesAndExecutorsForm();
        public GiftsAndYourEstateForm step3 = new GiftsAndYourEstateForm();
        public FuneralWishesForm step4 = new FuneralWishesForm();

        public PersonalDetailForm personalDetail = new PersonalDetailForm();
        //public Create_Report report = new Create_Report();

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

        [Test, Order(1)]
        [Category("Pay")]
        public void PaySingle()
        {
            createUser.CreateNewWillType0(driver,0);
            step1.SelectEstateAccesStep1(driver);
            step1.Step1Customer(driver,"Married");
            step1.Step1Partner(driver);
            step1.Step1ChildrenExist(driver,1);
            step1.Step1PetExist(driver,1);
            step2.SelectEstateAccesStep2(driver,Environment);
            step2.LegalGuardianAndTrustee(driver);
            

        }

        [Test, Order(2)]
        [Category("Pay")]

        public void PayCouple()
        {
            createUser.CreateNewWillType0(driver, 0);
            personalDetail.SelectEstateAccesStep1(driver);
            personalDetail.Step1Customer(driver, "Single");
            personalDetail.Step1ChildrenExist(driver, 1);
            personalDetail.Step1PetExist(driver, 1);
        }

        [Test, Order(1)]
        [Category("Pay")]
        public void PaySingleDiscount()
        {
            createUser.CreateNewWillType0(driver, 0);
            personalDetail.SelectEstateAccesStep1(driver);
            personalDetail.Step1Customer(driver, "Married");
            personalDetail.Step1Partner(driver);
            personalDetail.Step1ChildrenExist(driver, 0);
            personalDetail.Step1AddChildren(driver);
            personalDetail.Step1PetExist(driver, 0);
            personalDetail.Step1AddPet(driver);
        }

        [Test, Order(2)]
        [Category("Pay")]

        public void PayCoupleDiscount()
        {
            createUser.CreateNewWillType0(driver, 0);
            personalDetail.SelectEstateAccesStep1(driver);
            personalDetail.Step1Customer(driver, "Single");
            personalDetail.Step1ChildrenExist(driver, 1);
            personalDetail.Step1PetExist(driver, 1);
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
