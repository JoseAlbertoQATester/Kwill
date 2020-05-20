using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Kwill.Automation.Domain.UserCases.Dashboard;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Support.Extensions;
using Kwill.Automation.Domain.Repository;
using System.IO;

namespace Kwill.Automation.Test
{
    class Information
    {
        public string Username { get; private set; }
        public string PasswordOK { get; private set; }
        public IWebDriver driver;
        readonly Blog blog = new Blog();
        readonly Contact contact = new Contact();
        readonly Executor executor = new Executor();
        readonly FAQS faqs = new FAQS();
        readonly Guide guide = new Guide();
        readonly Home home = new Home();
        //readonly Send_Result send = new Send_Result();
        readonly public Create_Report report = new Create_Report();
        public bool resultok;
        public bool final;
        public string result;

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
        [Category("Blog")]
        public void Access_Article_In_Blog_Page()
        {
            resultok = blog.AccessArticlePage(driver);
            Assert.IsTrue(resultok, "It is displayed a diferent article");
        }

        [Test]
        [Category("Contact")]
        public void Contact_KWill()
        {
            resultok = contact.ContactwithKwill(driver);
            Assert.IsTrue(resultok, "Message is not send correctly");
        }

        [Test]
        [Category("Executor")]
        public void Access_Executor_Page()
        {
            resultok = executor.AccessExecutorPage(driver);
            Assert.IsTrue(resultok, "Not all information can be displayed");
        }

        [Test]
        [Category("FAQS")]
        public void Access_FAQS_Page()
        {
            resultok = faqs.AccessFAQSPage(driver);
            Assert.IsTrue(resultok, "Not all information can be displayed");
        }

        [Test]
        [Category("Guide")]
        public void Access_Guide()
        {
            result = guide.GetGuide(driver);
            Assert.AreEqual(result, "https://qwillstaging.blob.core.windows.net/files/kwil-will-writing-guide-v6.pdf", "Pdf is not displayed");
        }

        [Test]
        [Category("Final")]

        public void Access_Home_Page()
        {
            final = true;
            result = home.AccessHomePage(driver);
            Assert.AreEqual(result, "http://beta.kwil.co.uk/");
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
                //    TestContext.CurrentContext.Test.Name.ToString() + ".png",
                //    final);
                //}
                //if (final)
                //{
                //    send.SendEmail();
                //    File.Delete(@"C:\Users\josealbertolagos\source\repos\Kwill\Kwill.Automation.Test\bin\Debug\netcoreapp3.1\ReportKwill.pdf");
                //}

                driver.Close();
            }
            catch (Exception)
            {
                driver.Quit();
                //send.SendEmail();
                //File.Delete(@"C:\Users\josealbertolagos\source\repos\Kwill\Kwill.Automation.Test\bin\Debug\netcoreapp3.1\ReportKwill.pdf");
            }

        }

    }
}
