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
        public AddAffiliate addAffiliate = new AddAffiliate();
        public ViewAffiliates viewAffiliates = new ViewAffiliates();

        ////public Create_Report report = new Create_Report();


        public string AdminUser { get; private set; }
        public string Environment { get; private set; }
        public string AdminPasswordOK { get; private set; }
        public bool result;
        public string LogIn { get; private set; }
        public IWebDriver driver;
        private string url;
        private int alert;
        private bool ok;

        [SetUp]
        public void Setup()
        {
            AdminUser = TestContext.Parameters["adminUser"].ToString();
            Environment = TestContext.Parameters["environment"].ToString();
            AdminPasswordOK = TestContext.Parameters["adminPasswordOK"].ToString();
            LogIn = TestContext.Parameters["webUrl"].ToString();
            driver = new ChromeDriver(TestContext.Parameters["driverPath"].ToString());
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
            driver.Url = LogIn;
        }

        //[Test]
        //[Category("Ambassador")]
        //public void Create_Udpadte_And_View_Ambassador()
        //{
        //    login.LoginCaseOK(driver, AdminUser, AdminPasswordOK);
        //    url=registerAmbassador.AccesRegisterAmbassador(driver);
        //    Assert.AreEqual("http://"+Environment+"kwil.co.uk/Admin/RegisterAmbassador", url, "Page incorrcet");
        //    alert=registerAmbassador.RegisterEmptyAmbassador(driver);
        //    Assert.IsTrue(alert.Equals(1), "Validation not working");
        //    alert=registerAmbassador.RegisterInvalidmbassador(driver);
        //    Assert.IsTrue(alert.Equals(1), "Validation not working");
        //    alert=registerAmbassador.RegisterCorrectAmbassador(driver);
        //    Assert.IsTrue(alert.Equals(0), "Validation not working");
        //    viewAmbassadors.AccesViewAmbassador(driver);
        //    Assert.AreEqual("http://" + Environment + "kwil.co.uk/Admin/Ambassadors", url, "Page incorrcet");
        //    viewAmbassadors.FiltrerByToday(driver);
        //    Assert.IsTrue(alert.CompareTo(1).Equals(1), "Filter not working");
        //    viewAmbassadors.FilterByName(driver, "hola");
        //    Assert.IsTrue(alert.Equals(1), "Filter not working");
        //    ok = viewAmbassadors.EditAmbassador(driver, 12);
        //    Assert.IsTrue(ok, "Edit not working correctly");
        //    viewAmbassadors.FilterByName(driver, "hola");
        //    Assert.IsTrue(alert.Equals(1), "Filter not working");
        //    viewAmbassadors.AddNoteAmbassador(driver);
        //    Assert.IsTrue(alert.Equals(1), "Note not add");
        //}
        //[Test]
        //[Category("Affiliate")]
        //public void Create_Udpadte_And_View_Affiliate()
        //{
        //    login.LoginCaseOK(driver, AdminUser, AdminPasswordOK);
        //    url = addAffiliate.AccesRegisterAffiliate(driver);
        //    Assert.AreEqual("http://" + Environment + "kwil.co.uk/Admin/AddAffiliate", url, "Page incorrcet");
        //    alert = addAffiliate.RegisterEmptyAffiliate(driver);
        //    Assert.IsTrue(alert.Equals(1), "Validation not working");
        //    alert = addAffiliate.RegisterInvalidmbAffiliate(driver);
        //    Assert.IsTrue(alert.Equals(1), "Validation not working");
        //    alert = addAffiliate.RegisterCorrectAffiliate(driver);
        //    Assert.IsTrue(alert.Equals(0), "Validation not working");
        //    url = viewAffiliates.AccesViewAffiliate(driver);
        //    Assert.AreEqual("http://" + Environment + "kwil.co.uk/Admin/Affiliates", url, "Page incorrcet");
        //    alert = viewAffiliates.FiltrerByToday(driver);
        //    Assert.IsTrue(alert.Equals(1), "Filter not working");
        //    alert = viewAffiliates.FilterByName(driver, "Astrid");
        //    Assert.IsTrue(alert.Equals(1), "Filter not working");
        //    ok = viewAffiliates.EditAffiliate(driver, "Tony");
        //    Assert.IsTrue(ok, "Edit not working correctly");
        //    alert = viewAffiliates.FilterByName(driver, "Tony");
        //    Assert.IsTrue(alert.Equals(1), "Filter not working");
        //    alert = viewAffiliates.AddNoteAffiliate(driver);
        //    Assert.IsTrue(alert.Equals(1), "Note not add");
        //}

        //[Test]
        //[Category("Code")]
        //public void Create_Update_And_Delete_Code()
        //{
        //    login.LoginCaseOK(driver, AdminUser, AdminPasswordOK);
        //    url = discountCodes.AccesDiscountCode(driver);
        //    Assert.AreEqual("http://" + Environment + "kwil.co.uk/Admin/DiscountCodes", url, "Page incorrcet");
        //    result = discountCodes.CreateCode(driver);
        //    Assert.IsTrue(result, "code is not create");
        //    result = discountCodes.UpdateCode(driver);
        //    Assert.IsTrue(result, "Code is not update");
        //    result = discountCodes.DeleteCode(driver);
        //    Assert.IsTrue(result, "Code is not detele");
        //}

        //[Test]
        //[Category("Agent")]
        //public void Create_Update_And_Delete_Agent()
        //{
        //    login.LoginCaseOK(driver, AdminUser, AdminPasswordOK);
        //    url = agents.AccesAgent(driver);
        //    Assert.AreEqual("http://" + Environment + "kwil.co.uk/Admin/Agents", url, "Page incorrcet");
        //    result = agents.CreateAgent(driver);
        //    Assert.IsTrue(result, "Agent is not create");
        //    result = agents.UpdateAgent(driver);
        //    Assert.IsTrue(result, "Agent is not update");
        //    result = agents.DeleteAgent(driver);
        //    Assert.IsFalse(result, "Agent is not detele");
        //}



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
