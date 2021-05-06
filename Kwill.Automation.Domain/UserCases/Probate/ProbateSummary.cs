using OpenQA.Selenium;

namespace Kwill.Automation.Domain.UserCases.Probate
{
    public class ProbateSummary
    {
        private bool OK;
        private  int values;
        bool[] validatios;
        private int index;

        public int GetOutcomeCount(IWebDriver driver)
        {
            return driver.FindElements(By.ClassName("check")).Count;
        }

        public string GetOutcomeText(IWebDriver driver, int section)
        {
            return driver.FindElements(By.ClassName("check"))[section].Text;
        }

        public void ClickOnButton(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-kwil")).Click();
        }

        public bool[] Validation(char[] array, IWebDriver driver)
        {
             values = driver.FindElements(By.ClassName("check")).Count;
             validatios = new bool[values];
             index = 0;
            if (array[0] == '0' && array[1] == '0')
            {
                OK = false;
                for (int i = 0; i < values; i++)
                {
                    if(driver.FindElements(By.ClassName("check"))[i].Text.Contains("The deceased had a property as a sole owner"))
                    { 
                        OK = true; 
                        
                    }
                    validatios.SetValue(OK,index);
                    index++;
                }
            }

            if (array[0] == '0' && array[1] == '1' && array[2] == '0')
            {
                OK = false;
                for (int i = 0; i < values; i++)
                {

                    if (driver.FindElements(By.ClassName("check"))[i].Text.Contains("The deceased had a property registered as tenants in common"))
                    {
                        OK = true;
                    }

                }
                validatios.SetValue(OK, index);
                index++;
            }
            if (array[0] == '0' && array[1] == '1' && array[2] == '1')
            {
                OK = false;
                for (int i = 0; i < values; i++)
                {
                    if(driver.FindElements(By.ClassName("check"))[i].Text.Contains("The deceased had a property but it is unknown if it was held as Joint Tenants"))
                    {
                        OK = true;
                    }
                }
                validatios.SetValue(OK, index);
                index++;
            }
            if (array[3] == '0')
            {
                OK = false;
                for (int i = 0; i < values; i++)
                {
                   if(driver.FindElements(By.ClassName("check"))[i].Text.Contains("The deceased had accounts worth over £5,000"))
                    {
                        OK = true;
                    }
                }
                validatios.SetValue(OK, index);
                index++;
            }
            if (array[4] == '0')
            {
                OK = false;
                for (int i = 0; i < values; i++)
                {
                    if(driver.FindElements(By.ClassName("check"))[i].Text.Contains("The deceased had investments worth over £10,000"))
                    {
                        OK = true;
                    }
                }
                validatios.SetValue(OK, index);
                index++;
            }
            if (array[5] == '0')
            {
                OK = false;
                for (int i = 0; i < values; i++)
                {
                    if(driver.FindElements(By.ClassName("check"))[i].Text.Contains("The deceased had insurance or pensions that will pay a lump sum to the estate"))
                    {
                        OK = true;
                    }
                }
                validatios.SetValue(OK, index);
                index++;
            }
            if (array[6] == '0')
            {
                OK = false;
                for (int i = 0; i < values; i++)
                {
                    if(driver.FindElements(By.ClassName("check"))[i].Text.Contains("The estate included business assets"))
                    {
                        OK = true;
                    }
                }

                validatios.SetValue(OK, index);
                index++;
            }
            if (array[7] == '0')
            {
                OK = false;
                for (int i = 0; i < values; i++)
                {
                    if(driver.FindElements(By.ClassName("check"))[i].Text.Contains("You have been asked for probate"))
                    {
                        OK = true;
                    }
                }
                validatios.SetValue(OK, index);

            }
            return validatios;
        }
    }
}
