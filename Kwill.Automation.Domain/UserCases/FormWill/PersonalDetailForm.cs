using Kwill.Automation.Data.Entities;
using Kwill.Automation.Domain.Entities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PunditLeagueAutomation.Domain.Repository;

namespace Kwill.Automation.Domain.UserCases.FormWill
{
    class PersonalDetailForm
    {
        readonly Generator generator = new Generator();

        readonly CustomerEntity customer = new CustomerEntity();

        readonly PartnerEntity partner = new PartnerEntity();

        readonly ChildrenEntity children = new ChildrenEntity();

        readonly PetEntity pet = new PetEntity();

        string name;


        public CustomerEntity step1Customer(IWebDriver driver)
        {
            name = generator.GeneratorString();
        
            driver.FindElement(By.Id("CustomerInfo_FirstName")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_MiddleName")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_LastName")).SendKeys(name);

            IWebElement maritalstatus = driver.FindElement(By.Id("ddl_maritalstatus"));
            SelectElement selectElement = new SelectElement(maritalstatus);
            selectElement.SelectByValue("Married"); 

            IWebElement day = driver.FindElement(By.Id("CustomerInfo_DateOfBirth_Day"));
            SelectElement dayselect = new SelectElement(day);
            dayselect.SelectByValue("1"); 

            IWebElement moth = driver.FindElement(By.Id("CustomerInfo_DateOfBirth_Month"));
            SelectElement mothselect = new SelectElement(moth);
            mothselect.SelectByValue("1");

            IWebElement year = driver.FindElement(By.Id("ddl_maritalstatus"));
            SelectElement yearselect = new SelectElement(year);
            yearselect.SelectByValue("1995");
            
            driver.FindElement(By.Id("CurrentAddress")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Address_Number")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Address_Street")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Address_Village")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Address_City")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Telephone")).SendKeys(name);
            driver.FindElement(By.Id("submitForm")).Click();

            return customer;
        }

        public string step1Partner(IWebDriver driver)
        {
            name = generator.GeneratorString();
            driver.FindElement(By.Id("add-person")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys(name);
            driver.FindElement(By.Id("lastName")).SendKeys(name);

            IWebElement relation = driver.FindElement(By.Id("ddl_relationship"));
            SelectElement selectElement = new SelectElement(relation);
            selectElement.SelectByValue("Son");

            IWebElement day = driver.FindElement(By.Id("dobDay"));
            SelectElement dayselect = new SelectElement(day);
            dayselect.SelectByValue("1");

            IWebElement moth = driver.FindElement(By.Id("dobMonth"));
            SelectElement mothselect = new SelectElement(moth);
            mothselect.SelectByValue("1");

            IWebElement year = driver.FindElement(By.Id("dobYear"));
            SelectElement yearselect = new SelectElement(year);
            yearselect.SelectByValue("1995");

            driver.FindElement(By.Id("CurrentAddress")).SendKeys(name);
            driver.FindElement(By.Id("Number")).SendKeys("10");
            driver.FindElement(By.Id("Street")).SendKeys(name);
            driver.FindElement(By.Id("Village")).SendKeys(name);
            driver.FindElement(By.Id("City")).SendKeys(name);

            driver.FindElements(By.ClassName("btn-block"))[0].Click();

            return driver.Url;
        }

        public void step1ChildrenExist(IWebDriver driver, int children)
        {
            driver.FindElements(By.ClassName("signup"))[children].Click();
        }

        public ChildrenEntity step1AddChildren(IWebDriver driver)
        {
            name = generator.GeneratorString();

            driver.FindElement(By.Id("add-person")).Click();
            driver.FindElements(By.ClassName("btn-block"))[1].Click();
            driver.FindElement(By.Id("add-person")).Click();

            driver.FindElement(By.Id("CustomerInfo_FirstName")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_MiddleName")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_LastName")).SendKeys(name);

            IWebElement maritalstatus = driver.FindElement(By.Id("ddl_maritalstatus"));
            SelectElement selectElement = new SelectElement(maritalstatus);
            selectElement.SelectByValue("Married");

            IWebElement day = driver.FindElement(By.Id("CustomerInfo_DateOfBirth_Day"));
            SelectElement dayselect = new SelectElement(day);
            dayselect.SelectByValue("1");

            IWebElement moth = driver.FindElement(By.Id("CustomerInfo_DateOfBirth_Month"));
            SelectElement mothselect = new SelectElement(moth);
            mothselect.SelectByValue("1");

            IWebElement year = driver.FindElement(By.Id("ddl_maritalstatus"));
            SelectElement yearselect = new SelectElement(year);
            yearselect.SelectByValue("1995");

            driver.FindElement(By.Id("CurrentAddress")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Address_Number")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Address_Street")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Address_Village")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Address_City")).SendKeys(name);
            driver.FindElement(By.Id("CustomerInfo_Telephone")).SendKeys(name);
            driver.FindElement(By.Id("submitForm")).Click();

            return children;
        }

        public void step1PetExist(IWebDriver driver, int pet)
        {
            driver.FindElements(By.ClassName("signup"))[pet].Click();
        }

        public ChildrenEntity step1AddPet(IWebDriver driver)
        {
            name = generator.GeneratorString();

            driver.FindElement(By.Id("add-person")).Click();
            driver.FindElements(By.ClassName("btn-block"))[1].Click();
            driver.FindElement(By.Id("add-person")).Click();

            driver.FindElement(By.Id("petName")).SendKeys(name);
            driver.FindElement(By.Id("petType")).SendKeys(name);
     
            return children;
        }

        public PetEntity step1EditPet(IWebDriver driver)
        {
            name = generator.GeneratorString();

            driver.FindElement(By.Id("add-person")).Click();
            driver.FindElements(By.ClassName("btn-block"))[1].Click();
            driver.FindElement(By.Id("add-person")).Click();

            driver.FindElement(By.Id("petName")).SendKeys(name);
            driver.FindElement(By.Id("petType")).SendKeys(name);

            return pet;
        }

        public int step1DeleteAllPet(IWebDriver driver)
        {
            int element = driver.FindElements(By.ClassName("person")).Count;

            for (int i=1; i < element*2 ; i= i+2 )
            {

                driver.FindElements(By.ClassName("edit"))[0].Click();

                driver.FindElements(By.ClassName("edit"))[0].Click();

            }

            return element-driver.FindElements(By.ClassName("person")).Count;
        }

        public int step1DeleteOnePet(IWebDriver driver)
        {

                driver.FindElements(By.ClassName("edit"))[1].Click();

                driver.FindElements(By.ClassName("edit"))[1].Click();

            
            return driver.FindElements(By.ClassName("person")).Count;
        }


    }
}
