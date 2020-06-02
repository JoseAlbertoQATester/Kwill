using Kwill.Automation.Data.Entities;
using Kwill.Automation.Domain.Entities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PunditLeagueAutomation.Domain.Repository;

namespace Kwill.Automation.Domain.UserCases.FormWill
{
    public class PersonalDetailForm
    {
        readonly Generator generator = new Generator();
        readonly CustomerEntity customer = new CustomerEntity();
        readonly PartnerEntity partner = new PartnerEntity();
        readonly ChildrenEntity children = new ChildrenEntity();
        readonly PetEntity pet = new PetEntity();
        string name;

        public void SelectEstateAccesStep1(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("btn-link"))[0].Click();
        }

        public CustomerEntity step1Customer(IWebDriver driver,string partner)
        {
            name = generator.GeneratorString();

            driver.FindElement(By.Id("firstname")).Clear();
            driver.FindElement(By.Id("middlename")).Clear();
            driver.FindElement(By.Id("lastname")).Clear();
            driver.FindElement(By.Id("CurrentAddress")).Clear();
            driver.FindElement(By.Id("CurrentAddress")).Clear();
            driver.FindElement(By.Id("address1")).Clear();
            driver.FindElement(By.Id("address2")).Clear();
            driver.FindElement(By.Id("CustomerInfo_Address_Village")).Clear();
            driver.FindElement(By.Id("CustomerInfo_Address_City")).Clear();
            driver.FindElement(By.Id("Customerphone")).Clear();

            driver.FindElement(By.Id("firstname")).SendKeys(name);
            driver.FindElement(By.Id("middlename")).SendKeys(name);
            driver.FindElement(By.Id("lastname")).SendKeys(name);

            driver.FindElement(By.Id("CustomerInfo_DateOfBirth_Day")).SendKeys("1");
            driver.FindElement(By.Id("CustomerInfo_DateOfBirth_Month")).SendKeys("1");
            driver.FindElement(By.Id("CustomerInfo_DateOfBirth_Year")).SendKeys("2002");

            driver.FindElement(By.Id("ddl_maritalstatus")).SendKeys(partner);
            
            driver.FindElement(By.Id("CurrentAddress")).SendKeys("E10 5AB");
            driver.FindElement(By.Id("address1")).SendKeys("731a");
            driver.FindElement(By.Id("address2")).SendKeys("High Road Leyton");
            driver.FindElement(By.Id("CustomerInfo_Address_Village")).SendKeys("AAAA");
            driver.FindElement(By.Id("CustomerInfo_Address_City")).SendKeys("ABERDEEN");
            driver.FindElement(By.Id("Customerphone")).SendKeys("07765121236");
            driver.FindElement(By.Id("submitForm")).Click();

            return customer;
        }

        public string step1Partner(IWebDriver driver)
        {
            name = generator.GeneratorString();

            driver.FindElement(By.Id("firstname")).Clear();
            driver.FindElement(By.Id("lastname")).Clear();
            driver.FindElement(By.Id("firstname")).SendKeys(name);
            driver.FindElement(By.Id("lastname")).SendKeys(name);

            
            driver.FindElement(By.Id("PartnerInfo_DateOfBirth_Day")).SendKeys("1");
            driver.FindElement(By.Id("PartnerInfo_DateOfBirth_Month")).SendKeys("1");
            driver.FindElement(By.Id("PartnerInfo_DateOfBirth_Year")).SendKeys("1995");

            driver.FindElement(By.Id("IsAddressSame")).Click();

            driver.FindElement(By.Id("submitForm")).Click();

            return driver.Url;
        }

        public void step1ChildrenExist(IWebDriver driver, int children)
        {
            driver.FindElements(By.ClassName("signup"))[children].Click();

            if (children == 1 && driver.FindElement(By.Id("modalRemove")).Displayed)
            {
                driver.FindElement(By.ClassName("btn-info")).Click();
            }
        }

        public ChildrenEntity step1AddChildren(IWebDriver driver)
        {
            name = generator.GeneratorString();
            driver.FindElement(By.Id("add-person")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys(name);
            driver.FindElement(By.Id("lastName")).SendKeys(name);
            driver.FindElement(By.Id("ddl_relationship")).SendKeys("Son");
            driver.FindElement(By.Id("dobDay")).SendKeys("1");
            driver.FindElement(By.Id("dobMonth")).SendKeys("January"); 
            driver.FindElement(By.Id("dobYear")).SendKeys("1995"); 
            driver.FindElement(By.Id("IsAddressSame")).Click();
            driver.FindElements(By.ClassName("btn-primary"))[1].Click();
            driver.FindElement(By.Id("submitForm")).Click();

            return children;
        }

        public void step1PetExist(IWebDriver driver, int pet)
        {
            driver.FindElements(By.ClassName("signup"))[pet].Click();

            if (pet == 1 && driver.Url.Contains("PetsExisting") && driver.FindElement(By.Id("modalRemove")).Displayed)
            {
                driver.FindElement(By.ClassName("btn-info")).Click();
            }
        }

        public PetEntity step1AddPet(IWebDriver driver)
        {
            name = generator.GeneratorString();

            driver.FindElement(By.Id("add-person")).Click();
            driver.FindElement(By.Id("petName")).SendKeys(name);
            driver.FindElement(By.Id("petType")).SendKeys(name);

            driver.FindElements(By.ClassName("btn-primary"))[0].Click();

            driver.FindElement(By.Id("submitForm")).Click();

            return pet;
        }

        public PetEntity step1EditPet(IWebDriver driver)
        {
            name = generator.GeneratorString();

            driver.FindElement(By.Id("add-person")).Click();

            driver.FindElement(By.Id("petName")).SendKeys(name);
            driver.FindElement(By.Id("petType")).SendKeys(name);

            driver.FindElements(By.ClassName("btn-primary"))[1].Click();

            driver.FindElement(By.Id("submitForm")).Click();

            return pet;
        }

        public int step1DeleteAllPet(IWebDriver driver)
        {
            int element = driver.FindElements(By.ClassName("person")).Count;

            for (int i = 1; i < element * 2; i = i + 2)
            {

                driver.FindElements(By.ClassName("edit"))[0].Click();

                driver.FindElements(By.ClassName("edit"))[0].Click();

            }

            return element - driver.FindElements(By.ClassName("person")).Count;
        }

        public int step1DeleteOnePet(IWebDriver driver)
        {
            driver.FindElements(By.ClassName("edit"))[1].Click();

            driver.FindElements(By.ClassName("edit"))[1].Click();


            return driver.FindElements(By.ClassName("person")).Count;
        }


    }
}
