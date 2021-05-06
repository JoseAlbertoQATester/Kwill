using OpenQA.Selenium;
using System;

namespace Kwill.Automation.Domain.UserCases.Probate
{
    public class ProbateQuestions
    {
        bool OK = false;
        public string GetQuestions(IWebDriver driver)
        {
            return driver.FindElement(By.ClassName("padbot30")).Text;
        }
        public string GetPicture(IWebDriver driver)
        {
            return driver.FindElements(By.TagName("img"))[1].GetAttribute("src");
        }
        public int GetAnswersCount(IWebDriver driver)
        {
            return driver.FindElements(By.ClassName("selectbox")).Count;
        }
        public string GetAnswersText(IWebDriver driver, int element)
        {
            string Answers="";
            for (int i =0; i<element;i++)
            {
                Answers = Answers + driver.FindElements(By.ClassName("selectbox"))[i].Text;
            }
            return Answers;
        }
        public void ClickOnAnswer(IWebDriver driver, char element)
        {

                driver.FindElements(By.ClassName("selectbox"))[Int32.Parse(element.ToString())].Click();

            
        }
        public void ClickOnGoBack(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("fa-chevron-circle-left")).Click();
        }

        public bool validation(int page, string picture, string question, int numberAnswers, string answers)
        {
            OK = false;

            if (page.Equals(1) && picture.Contains("house.png") && question.Equals("Did the deceased person own a property?") && numberAnswers.Equals(2)  && answers.Equals("YesNo"))
            {
                OK = true;
            }
            else if (page.Equals(2) && picture.Contains("house.png") && question.Equals("Is the property held in the sole name of the deceased person?") && numberAnswers.Equals(2) && answers.Equals("YesNo"))
            {
                OK = true;
            }
            else if (page.Equals(3) && picture.Contains("house.png") && question.Equals("How is the property owned?") && numberAnswers.Equals(3) && answers.Equals("Tenants in CommonDon't KnowJoint Tenants"))
            {
                OK = true;
            }
            else if (page.Equals(4) && picture.Contains("12-probate-banks.png") && question.Equals("Did the deceased have bank accounts, building society accounts or investments worth over £5,000 on the date of their death?") && numberAnswers.Equals(2) && answers.Equals("YesNo"))
            {
                OK = true;
            }
            else if (page.Equals(5) && picture.Contains("14-probate-shares.png") && question.Equals("Did the deceased have any shares worth over £10,000?") && numberAnswers.Equals(2) && answers.Equals("YesNo"))
            {
                OK = true;
            }
            else if (page.Equals(6) && picture.Contains("estate-money.png") && question.Equals("Did the deceased have any pensions or life insurance policies that will pay a lump sum to the estate?") && numberAnswers.Equals(2) && answers.Equals("YesNo"))
            {
                OK = true;
            }
            else if (page.Equals(7) && picture.Contains("05-probate-info.png") && question.Equals("Did the deceased have any farming or business assets or interests?") && numberAnswers.Equals(2) && answers.Equals("YesNo"))
            {
                OK = true;
            }
            else if (page.Equals(8) && picture.Contains("06-probate-forms.png") && question.Equals("Have you been asked for probate?") && numberAnswers.Equals(2) && answers.Equals("YesNo"))
            {
                OK = true;
            }
            else
            {
                OK = false;
            }
            return OK;
        }

    }
}
