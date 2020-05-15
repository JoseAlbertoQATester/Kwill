using Kwill.Automation.Data.Entities;
using Kwill.Automation.Domain.Entities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PunditLeagueAutomation.Domain.Repository;

namespace Kwill.Automation.Domain.UserCases.FormWill
{
    public class FuneralWishesForm
    {
        public void SelectEstateAccesStep4(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("btn-link"))[3].Click();
        }

        public int SelectFuneralDetail(IWebDriver driver, int select)
        {
            if (driver.Url == "http://beta.kwil.co.uk/Steps/Funeral/Funeral")
            {
                if (select == 0)
                {
                    driver.FindElements(By.Id("FuneralVmInfo_FuneralTypeId"))[0].Click();
                }
                else if (select == 1)
                {
                    driver.FindElements(By.Id("FuneralVmInfo_FuneralTypeId"))[1].Click();
                }
                else if (select == 2)
                {
                    driver.FindElements(By.Id("FuneralVmInfo_FuneralTypeId"))[2].Click();
                }

                driver.FindElement(By.Id("submitForm")).Click();

                if (!driver.FindElements(By.ClassName("card-body"))[3].Text.Contains("Step Completed"))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else 
            {
                return 2; 
            }
                
            
        }

        public int ViewFuneralDetail(IWebDriver driver, int select)
        {
            if (!driver.FindElements(By.Id("FuneralVmInfo_FuneralTypeId"))[select].Selected)
            {
                return 1;
            }
            driver.FindElement(By.ClassName("btn-link")).Click();
            if (!driver.Url.Contains("http://beta.kwil.co.uk/Dashboard/Summary"))
            {
                return 3;
            }
            if (!driver.FindElements(By.ClassName("card-body"))[3].Text.Contains("Step Completed"))
            {
                return 3;
            }

            else if (!driver.FindElements(By.ClassName("card-body"))[3].Text.Contains("edit") &&
                     driver.FindElements(By.ClassName("card-body"))[3].Text.Contains("Begin"))
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
