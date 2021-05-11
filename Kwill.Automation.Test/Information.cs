using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Kwill.Automation.Domain.UserCases.Dashboard;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Support.Extensions;
using Kwill.Automation.Domain.Repository;
using System.IO;
using Kwill.Automation.Domain.UserCases;

namespace Kwill.Automation.Test
{
    class Information
    {
        public string Environment { get; private set; }
        public string Username { get; private set; }
        public string PasswordOK { get; private set; }
        public IWebDriver driver;
        readonly LogIn logIn = new LogIn();
        readonly Blog blog = new Blog();
        readonly Contact contact = new Contact();
        readonly Executor executor = new Executor();
        readonly FAQS faqs = new FAQS();
        readonly Guide guide = new Guide();
        readonly GuideLogOut guideLogout = new GuideLogOut();
        readonly Home home = new Home();
        //readonly Send_Result send = new Send_Result();
        //readonly //public Create_Report report = new Create_Report();
        public bool resultok;
        public string result;

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
        [Category("Blog")]
        public void Access_Article_In_Blog_Page()
        {
            resultok = blog.AccessArticlePage(driver,Environment);
            Assert.IsTrue(resultok, "It is displayed a diferent article");
        }

        [Test]
        [Category("Contact")]
        public void Contact_KWill()
        {
            resultok = contact.ContactwithKwill(driver,Environment);
            Assert.IsTrue(resultok, "Message is not send correctly");
        }

        [Test]
        [Category("Executor")]
        public void Access_Executor_Page()
        {
            resultok = executor.AccessExecutorPage(driver,Environment);
            Assert.IsTrue(resultok, "Not all information can be displayed");
        }

        [Test]
        [Category("FAQS")]
        public void Access_FAQS_Page()
        {
            resultok = faqs.AccessFAQSPage(driver, Environment);
            Assert.IsTrue(resultok, "Not all information can be displayed");
        }

        //[Test]
        //[Category("Guide")]
        //public void Access_Guide()
        //{
        //    logIn.LoginCaseOK(driver,Username,PasswordOK);
        //    result = guide.GetGuide(driver, Environment);
        //    Assert.AreEqual(result, "http://" + Environment + "kwil.co.uk/guide", "Pdf is not displayed");
        //}


        [Test]
        [Category("Guide")]
        public void Access_Guide_LogOut()
        {
            resultok = guideLogout.GetGuide(driver, Environment);
            Assert.AreEqual(true, resultok, "Request has not been sent");
        }

        [Test]
        [Category("Final")]

        public void Access_Home_Page()
        {
            result = home.AccessHomePage(driver);
            Assert.AreEqual(result, "http://" + Environment + "kwil.co.uk/");
        }

        [TearDown]
        public void Close()
        {
            try
            {
                if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Passed)
                {
                    driver.TakeScreenshot().SaveAsFile(TestContext.CurrentContext.Test.Name.ToString() + ".png", ScreenshotImageFormat.Png);

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
