using OpenQA.Selenium;
using System;

namespace Kwill.Automation.Domain.Pages
{
    class PetsPage
    {
        public void AddPet(IWebDriver driver)
        {
            driver.FindElement(By.Id("add-person")).Click();
        }
        public void ClickOnNext(IWebDriver driver)
        {
            driver.FindElement(By.Id("submitForm")).Click();
        }
        public void ClickOnGoBack(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-outline-dark")).Click();
        }
        public void IntroduceName(IWebDriver driver,string name)
        {
            driver.FindElement(By.Id("petName")).SendKeys(name);
        }
        public void IntroduceType(IWebDriver driver, string type)
        {
            driver.FindElement(By.Id("petType")).SendKeys(type);
        }
        public void ClickOnSavePet(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("btn-primary"))[driver.FindElements(By.ClassName("btn-primary")).Count - 3].Click();
        }
        public void ClickOnCancelSavePet(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("btn-primary"))[1].Click();
        }
        public void ClickOnEditPet(IWebDriver driver, int position)
        {
            driver.FindElements(By.ClassName("edit"))[position * 2].Click();
        }
        public void ClickOnDeletePet(IWebDriver driver,decimal position)
        {
            driver.FindElements(By.ClassName("edit"))[Decimal.ToInt32(Math.Round(position / 2))].Click();
        }
        public void ClickOnNoRemovePet(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-info")).Click();
        }
        public void ClickOnRemovePet(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("btn-danger")).Click();
        }
    }
}
