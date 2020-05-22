using Kwill.Automation.Domain.Repository;
using Kwill.Automation.Domain.UserCases;
using Kwill.Automation.Domain.UserCases.Admin;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kwill.Automation.Test
{
    class Admin
    {
        public LogIn login = new LogIn();

        public LogOut logout = new LogOut();

        public RegisterAmbassador registerAmbassador = new RegisterAmbassador();
        public ViewAmbassadors viewAmbassadors = new ViewAmbassadors();
        public DiscountCodes discountCodes = new DiscountCodes();
        public Agents agents = new Agents();
        //public Create_Report report = new Create_Report();


        public string adminUser { get; private set; }
        public string adminPasswordOK { get; private set; }
        public bool result;
        public string LogIn { get; private set; }
        public IWebDriver driver;
        private string url;

        [SetUp]
        public void Setup()
        {
            adminUser = TestContext.Parameters["adminUser"].ToString();
            adminPasswordOK = TestContext.Parameters["adminPasswordOK"].ToString();
            LogIn = TestContext.Parameters["webUrl"].ToString();
            driver = new ChromeDriver(TestContext.Parameters["driverPath"].ToString());
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
            driver.Url = LogIn;
        }

        [Test]
        [Category("Ambassador")]
        public void Create_Udpadte_And_View_Ambassador()
        {
            login.LoginCaseOK(driver, adminUser, adminPasswordOK);
            registerAmbassador.AccesRegisterAmbassador(driver);
            registerAmbassador.RegisterEmptyAmbassador(driver);
            registerAmbassador.RegisterInvalidmbassador(driver);
            registerAmbassador.RegisterCorrectAmbassador(driver);
            viewAmbassadors.AccesViewAmbassador(driver);
            viewAmbassadors.FiltrerByToday(driver);
            viewAmbassadors.FilterByName(driver, "hola");
            viewAmbassadors.EditAmbassador(driver, 12);
            viewAmbassadors.FilterByName(driver, "hola");
            viewAmbassadors.AddNoteAmbassador(driver);
        }

        [Test]
        [Category("Code")]
        public void Create_Update_Delete_Code()
        {
            login.LoginCaseOK(driver, adminUser, adminPasswordOK);
            url = discountCodes.AccesDiscountCode(driver);
            Assert.AreEqual("http://beta.kwil.co.uk/Admin/DiscountCodes", url, "Page incorrcet");
            result = discountCodes.createCode(driver);
            Assert.IsTrue(result, "code is not create");
            result = discountCodes.updateCode(driver);
            Assert.IsTrue(result, "Code is not update");
            result = discountCodes.DeleteCode(driver);
            Assert.IsTrue(result, "Code is not detele");
        }

        [Test]
        [Category("Code")]
        public void Create_Update_Delete_Agent()
        {
            login.LoginCaseOK(driver, adminUser, adminPasswordOK);
            url = agents.AccesAgent(driver);
            Assert.AreEqual("http://beta.kwil.co.uk/Admin/Agents", url, "Page incorrcet");
            result = agents.createAgent(driver);
            Assert.IsTrue(result, "Agent is not create");
            result = agents.updateAgent(driver);
            Assert.IsTrue(result, "Agent is not update");
            result = agents.DeleteAgent(driver);
            Assert.IsFalse(result, "Agent is not detele");
        }



        [TearDown]
        public void Close()
        {
            try
            {
                //if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Passed)
                //{
                //    driver.TakeScreenshot().SaveAsFile(TestContext.CurrentContext.Test.Name.ToString() + ".png", ScreenshotImageFormat.Png);
                //    report.CreateRepor(
                //    TestContext.CurrentContext.Test.Name,
                //    TestContext.CurrentContext.Result.Message,
                //    TestContext.CurrentContext.Test.Name.ToString() + ".png"
                //    );
                //}

                driver.Close();
            }
            catch (Exception)
            {
                driver.Quit();
            }

        }

    }
}
