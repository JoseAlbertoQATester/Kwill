using Kwill.Automation.Domain.UserCases.Probate;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Kwill.Automation.Test
{
    class ProbatePage
    {
        public string Environment { get; private set; }

        public string webUrlDashboard;
        public string Username { get; private set; }
        public string PasswordOK { get; private set; }
        public string LogIn { get; private set; }

        public IWebDriver driver;

        char[] arr;

        ProbatePages probatePages = new ProbatePages();
        ProbateForm probateForm = new ProbateForm();
        ProbateQuestions probateQuestions = new ProbateQuestions();
        ProbateSummary probateSummary = new ProbateSummary();
        private int page;
        private int exit;
        private bool globalValidation1;
        private int globalValidation2;

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
        }

        [TestCase("0100000N")]
        [TestCase("0100000N")]
        [TestCase("01000010")]
        [TestCase("01000011")]
        [TestCase("0100010N")]
        [TestCase("0100010N")]
        [TestCase("01000110")]
        [TestCase("01000111")]
        [TestCase("0100100N")]
        [TestCase("0100100N")]
        [TestCase("01001010")]
        [TestCase("01001011")]
        [TestCase("0100110N")]
        [TestCase("0100110N")]
        [TestCase("01001110")]
        [TestCase("01001111")]
        [TestCase("0101000N")]
        [TestCase("0101000N")]
        [TestCase("01010010")]
        [TestCase("01010011")]
        [TestCase("0101010N")]
        [TestCase("0101010N")]
        [TestCase("01010110")]
        [TestCase("01010111")]
        [TestCase("0101100N")]
        [TestCase("0101100N")]
        [TestCase("01011010")]
        [TestCase("01011011")]
        [TestCase("0101110N")]
        [TestCase("0101110N")]
        [TestCase("01011110")]
        [TestCase("01011111")]
        [TestCase("0110000N")]
        [TestCase("0110000N")]
        [TestCase("01100010")]
        [TestCase("01100011")]
        [TestCase("0110010N")]
        [TestCase("0110010N")]
        [TestCase("01100110")]
        [TestCase("01100111")]
        [TestCase("0110100N")]
        [TestCase("0110100N")]
        [TestCase("01101010")]
        [TestCase("01101011")]
        [TestCase("0110110N")]
        [TestCase("0110110N")]
        [TestCase("01101110")]
        [TestCase("01101111")]
        [TestCase("0111000N")]
        [TestCase("0111000N")]
        [TestCase("01110010")]
        [TestCase("01110011")]
        [TestCase("0111010N")]
        [TestCase("0111010N")]
        [TestCase("01110110")]
        [TestCase("01110111")]
        [TestCase("0111100N")]
        [TestCase("0111100N")]
        [TestCase("01111010")]
        [TestCase("01111011")]
        [TestCase("0111110N")]
        [TestCase("0111110N")]
        [TestCase("01111110")]
        [TestCase("01111111")]
        [TestCase("0120000N")]
        [TestCase("0120000N")]
        [TestCase("01200010")]
        [TestCase("01200011")]
        [TestCase("0120010N")]
        [TestCase("0120010N")]
        [TestCase("01200110")]
        [TestCase("01200111")]
        [TestCase("0120100N")]
        [TestCase("0120100N")]
        [TestCase("01201010")]
        [TestCase("01201011")]
        [TestCase("0120110N")]
        [TestCase("0120110N")]
        [TestCase("01201110")]
        [TestCase("01201111")]
        [TestCase("0121000N")]
        [TestCase("0121000N")]
        [TestCase("01210010")]
        [TestCase("01210011")]
        [TestCase("0121010N")]
        [TestCase("0121010N")]
        [TestCase("01210110")]
        [TestCase("01210111")]
        [TestCase("0121100N")]
        [TestCase("0121100N")]
        [TestCase("01211010")]
        [TestCase("01211011")]
        [TestCase("0121110N")]
        [TestCase("0121110N")]
        [TestCase("01211110")]
        [TestCase("01211111")]
        [TestCase("1NN0000N")]
        [TestCase("1NN0000N")]
        [TestCase("1NN00010")]
        [TestCase("1NN00011")]
        [TestCase("1NN0010N")]
        [TestCase("1NN0010N")]
        [TestCase("1NN00110")]
        [TestCase("1NN00111")]
        [TestCase("1NN0100N")]
        [TestCase("1NN0100N")]
        [TestCase("1NN01010")]
        [TestCase("1NN01011")]
        [TestCase("1NN0110N")]
        [TestCase("1NN0110N")]
        [TestCase("1NN01110")]
        [TestCase("1NN01111")]
        [TestCase("1NN1000N")]
        [TestCase("1NN1000N")]
        [TestCase("1NN10010")]
        [TestCase("1NN10011")]
        [TestCase("1NN1010N")]
        [TestCase("1NN1010N")]
        [TestCase("1NN10110")]
        [TestCase("1NN10111")]
        [TestCase("1NN1100N")]
        [TestCase("1NN1100N")]
        [TestCase("1NN11010")]
        [TestCase("1NN11011")]
        [TestCase("1NN1110N")]
        [TestCase("1NN1110N")]
        [TestCase("1NN11110")]
        [TestCase("1NN11111")]
        [TestCase("1NN0000N")]
        [TestCase("1NN0000N")]
        [TestCase("1NN00010")]
        [TestCase("1NN00011")]
        [TestCase("1NN0010N")]
        [TestCase("1NN0010N")]
        [TestCase("1NN00110")]
        [TestCase("1NN00111")]
        [TestCase("1NN0100N")]
        [TestCase("1NN0100N")]
        [TestCase("1NN01010")]
        [TestCase("1NN01011")]
        [TestCase("1NN0110N")]
        [TestCase("1NN0110N")]
        [TestCase("1NN01110")]
        [TestCase("1NN01111")]
        [TestCase("1NN1000N")]
        [TestCase("1NN1000N")]
        [TestCase("1NN10010")]
        [TestCase("1NN10011")]
        [TestCase("1NN1010N")]
        [TestCase("1NN1010N")]
        [TestCase("1NN10110")]
        [TestCase("1NN10111")]
        [TestCase("1NN1100N")]
        [TestCase("1NN1100N")]
        [TestCase("1NN11010")]
        [TestCase("1NN11011")]
        [TestCase("1NN1110N")]
        [TestCase("1NN1110N")]
        [TestCase("1NN11110")]
        [TestCase("1NN11111")]
        [TestCase("1NN0000N")]
        [TestCase("1NN0000N")]
        [TestCase("1NN00010")]
        [TestCase("1NN00011")]
        [TestCase("1NN0010N")]
        [TestCase("1NN0010N")]
        [TestCase("1NN00110")]
        [TestCase("1NN00111")]
        [TestCase("1NN0100N")]
        [TestCase("1NN0100N")]
        [TestCase("1NN01010")]
        [TestCase("1NN01011")]
        [TestCase("1NN0110N")]
        [TestCase("1NN0110N")]
        [TestCase("1NN01110")]
        [TestCase("1NN01111")]
        [TestCase("1NN1000N")]
        [TestCase("1NN1000N")]
        [TestCase("1NN10010")]
        [TestCase("1NN10011")]
        [TestCase("1NN1010N")]
        [TestCase("1NN1010N")]
        [TestCase("1NN10110")]
        [TestCase("1NN10111")]
        [TestCase("1NN1100N")]
        [TestCase("1NN1100N")]
        [TestCase("1NN11010")]
        [TestCase("1NN11011")]
        [TestCase("1NN1110N")]
        [TestCase("1NN1110N")]
        [TestCase("1NN11110")]
        [TestCase("1NN11111")]


        public void CompleteProbatePrerequisites(string array)
        {
            arr = array.ToCharArray(0 , 8);
            probatePages.accessToProbatePage(driver);
            probatePages.ClickOnGoProbateButton(driver);

            for (int i = 0; i < arr.Length; i++)
            {
                if (!arr[i].Equals('N'))
                {
                    page = i + 1;
                    string picture = probateQuestions.GetPicture(driver);
                    string question = probateQuestions.GetQuestions(driver);
                    int count = probateQuestions.GetAnswersCount(driver);
                    string answers = probateQuestions.GetAnswersText(driver, count);
                    globalValidation1 = probateQuestions.validation(page, picture, question, count, answers);
                    probateQuestions.ClickOnAnswer(driver, arr[i]);
                }
            }
            exit = probateSummary.GetOutcomeCount(driver);
            bool[] validatios = probateSummary.Validation(arr, driver);

            for (int i = 0; i < probateSummary.GetOutcomeCount(driver); i++)
            {
                if (validatios[i])
                {
                    globalValidation2++;
                }

            }

            Assert.IsTrue( globalValidation1 && globalValidation2.Equals(exit));
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
