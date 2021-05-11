using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Kwill.Automation.Domain.UserCases;
using Kwill.Automation.Domain.Repository;
using Kwill.Automation.Domain.UserCases.FormWill;
using Kwill.Automation.Domain.UserCases.FormWill.Step_1;

namespace Kwill.Automation.Test
{
    class Step1
    {
        public LogIn login = new LogIn();
        public LogOut logout = new LogOut();
        public PersonalDetailForm personalDetail = new PersonalDetailForm();
        CompleteCustomerCorrectly CompleteStep1 = new CompleteCustomerCorrectly();
        //public Create_Report report = new Create_Report();

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
            driver = new ChromeDriver(TestContext.Parameters["driverPath"].ToString());
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
        }

        [Test, Order(1)]
        [Category("Step1")]
        public void Complete_Step1_As_Married_NotChildren_NotPets()
        {
            login.LoginCaseOK(driver);

            CompleteStep1.CompleteCustomer_Married_NoChild_NoPet_Correct(driver);

            Assert.IsTrue(driver.Url.Contains("https://beta.kwil.co.uk/Dashboard/Summary"));
        }

        [Test, Order(2)]
        [Category("Step1")]
        public void Complete_Step1_As_Single_NotChildren_NotPets()
        {
            login.LoginCaseOK(driver);

            CompleteStep1.CompleteCustomer_Single_NoChild_NoPet_Correct(driver);

            Assert.IsTrue(driver.Url.Contains("https://beta.kwil.co.uk/Dashboard/Summary"));
        }

        [Test, Order(3)]
        [Category("Step1")]
        public void Complete_Step1_As_Single_Children_Pets()
        {
            login.LoginCaseOK(driver);

            CompleteStep1.CompleteCustomer_Single_Child_Pet_Correct(driver);

            Assert.IsTrue(driver.Url.Contains("https://beta.kwil.co.uk/Dashboard/Summary"));
        }

        [Test, Order(4)]
        [Category("Step1")]
        public void Complete_Step1_As_Married_Children_Pets()
        {
            login.LoginCaseOK(driver);

            CompleteStep1.CompleteCustomer_Married_Child_Pet_Correct(driver);

            Assert.IsTrue(driver.Url.Contains("https://beta.kwil.co.uk/Dashboard/Summary"));
        }


        //     [Test,Order(1)]
        //     [Category("Step1")]

        //     public void Step1EndNotChildrenNotPetNotPatner()
        //     {
        //         login.LoginCaseOK(driver, "Correct");
        //         personalDetail.SelectEstateAccesStep1(driver);
        //         personalDetail.Step1Customer(driver, "Single");
        //         personalDetail.Step1ChildrenExist(driver, 1);
        //         personalDetail.Step1PetExist(driver, 1);
        //     }


        //     [Test, Order(3)]
        //     [Category("Step1")]
        //     public void Step1EndNotChildren()
        //     {
        //         login.LoginCaseOK(driver, "Correct");
        //         personalDetail.SelectEstateAccesStep1(driver);
        //         personalDetail.Step1Customer(driver, "Single");
        //         personalDetail.Step1ChildrenExist(driver, 1);
        //         personalDetail.Step1PetExist(driver, 0);
        //         personalDetail.Step1AddPet(driver);
        //     }


        //     [Test, Order(4)]
        //     [Category("Step1")]
        //     public void Step1EndNotPet()
        //     {
        //         login.LoginCaseOK(driver, "Correct");
        //         personalDetail.SelectEstateAccesStep1(driver);
        //         personalDetail.Step1Customer(driver, "Single");
        //         personalDetail.Step1ChildrenExist(driver, 0);
        //         personalDetail.Step1AddChildren(driver);
        //         personalDetail.Step1PetExist(driver, 1);
        //     }

        //    // [Test]
        //     [Category("Step1Stress")]
        //     public void Step1StressChild()
        //     {
        //         login.LoginCaseOK(driver, "Correct");
        //         personalDetail.SelectEstateAccesStep1(driver);
        //         personalDetail.Step1Customer(driver, "Single");
        //         counter = 0;
        //         personalDetail.Step1ChildrenExist(driver, 0);
        //         while (true)
        //         {
        //             personalDetail.Step1AddChildren(driver);
        //             counter++;
        //             Assert.AreEqual(driver.Url, "");

        //         }
        //     }

        ////     [Test]
        //     [Category("Step1Stress")]
        //     public void Step1StressPet()
        //     {
        //         login.LoginCaseOK(driver, "Correct");
        //         personalDetail.SelectEstateAccesStep1(driver);
        //         personalDetail.Step1Customer(driver, "Single");
        //         counter = 0;
        //         personalDetail.Step1ChildrenExist(driver, 0);
        //         personalDetail.Step1AddChildren(driver);
        //         personalDetail.Step1PetExist(driver, 0);
        //         while (true)
        //         {
        //             personalDetail.Step1AddPet(driver);
        //             counter++;
        //             Assert.AreEqual(driver.Url, "");
        //         }

        //     }

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
