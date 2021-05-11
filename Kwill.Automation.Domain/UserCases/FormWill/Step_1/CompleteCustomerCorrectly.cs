using Kwill.Automation.Domain.Repository;
using Kwill.Automation.Domain.Entities;
using Kwill.Automation.Domain.Pages;
using OpenQA.Selenium;

namespace Kwill.Automation.Domain.UserCases.FormWill.Step_1
{
    public class CompleteCustomerCorrectly
    {
        SummaryPage summary = new SummaryPage();

        CustomerPage customer = new CustomerPage();
        PartnerPage partner = new PartnerPage();
        ChildrenExistingPage childrenExisting = new ChildrenExistingPage();
        ChildrenPage children = new ChildrenPage();
        PetsExistingPage petsExisting = new PetsExistingPage();
        PetsPage pets = new PetsPage();

        CustomerEntity customerEntity = new CustomerEntity();
        PartnerEntity partnerEntity = new PartnerEntity();
        ChildrenEntity childrenEntity = new ChildrenEntity();
        PetEntity petEntity = new PetEntity();

        GeneralRepository repository = new GeneralRepository();

        public string CompleteCustomer_Single_NoChild_NoPet_Correct(IWebDriver driver)
        {
            customerEntity = repository.GetCustomer("Single");

            summary.AccessToStep1(driver);

            customer.IntroduceFirstName(driver, customerEntity.FirstName);
            customer.IntroduceLastName(driver, customerEntity.LastName);
            customer.IntroduceBirthday(driver, customerEntity.Day, customerEntity.Month, customerEntity.Year);
            customer.IntroduceMatitalStatus(driver, customerEntity.MaritalStatus);
            customer.IntroducePostCode(driver, customerEntity.PostCode);
            customer.IntroduceNumber(driver, customerEntity.Address1);
            customer.IntroduceStreet(driver, customerEntity.Address2);
            customer.IntroduceVillage(driver, customerEntity.Town);
            customer.IntroducePhone(driver, customerEntity.Telephone);
            customer.ClickOnNext(driver);

            childrenExisting.ClickOnNo(driver);

            petsExisting.ClickOnNo(driver);

            return driver.Url;
        }

        public string CompleteCustomer_Married_NoChild_NoPet_Correct(IWebDriver driver)
        {
            customerEntity = repository.GetCustomer("Married");
            partnerEntity = repository.GetPartner("Correct");

            summary.AccessToStep1(driver);

            customer.IntroduceFirstName(driver, customerEntity.FirstName);
            customer.IntroduceLastName(driver, customerEntity.LastName);
            customer.IntroduceBirthday(driver, customerEntity.Day, customerEntity.Month, customerEntity.Year);
            customer.IntroduceMatitalStatus(driver, customerEntity.MaritalStatus);
            customer.IntroducePostCode(driver, customerEntity.PostCode);
            customer.IntroduceNumber(driver, customerEntity.Address1);
            customer.IntroduceStreet(driver, customerEntity.Address2);
            customer.IntroduceVillage(driver, customerEntity.Town);
            customer.IntroducePhone(driver, customerEntity.Telephone);
            customer.ClickOnNext(driver);

            partner.IntroduceFirstName(driver, partnerEntity.FirstName);
            partner.IntroduceLastName(driver, partnerEntity.LastName);
            partner.IntroduceBirthday(driver, partnerEntity.Day, partnerEntity.Month, partnerEntity.Year);
            partner.IntroducePostCode(driver, partnerEntity.PostCode);
            partner.IntroduceNumber(driver, partnerEntity.Address1);
            partner.IntroduceStreet(driver, partnerEntity.Address2);
            partner.IntroduceVillage(driver, partnerEntity.Town);
            partner.IntroduceCity(driver, partnerEntity.City);
            partner.ClickOnNext(driver);

            childrenExisting.ClickOnNo(driver);

            petsExisting.ClickOnNo(driver);

            return driver.Url;
        }

        public string CompleteCustomer_Single_Child_Pet_Correct(IWebDriver driver)
        {
            customerEntity = repository.GetCustomer("Single");
            childrenEntity = repository.GetChildren("Correct");

            summary.AccessToStep1(driver);

            customer.IntroduceFirstName(driver, customerEntity.FirstName);
            customer.IntroduceLastName(driver, customerEntity.LastName);
            customer.IntroduceBirthday(driver, customerEntity.Day, customerEntity.Month, customerEntity.Year);
            customer.IntroduceMatitalStatus(driver, customerEntity.MaritalStatus);
            customer.IntroducePostCode(driver, customerEntity.PostCode);
            customer.IntroduceNumber(driver, customerEntity.Address1);
            customer.IntroduceStreet(driver, customerEntity.Address2);
            customer.IntroduceVillage(driver, customerEntity.Town);
            customer.IntroducePhone(driver, customerEntity.Telephone);
            customer.ClickOnNext(driver);

            childrenExisting.ClickOnYes(driver);

            children.AddChild(driver);
            children.IntroduceFirstName(driver, childrenEntity.FirstName);
            children.IntroduceLastName(driver, childrenEntity.LastName);
            children.IntroduceBirthday(driver, childrenEntity.Day,childrenEntity.Month,childrenEntity.Year);
            children.IntroduceRelationship(driver,childrenEntity.Relation);
            children.IntroducePostcode(driver, childrenEntity.PostCode);
            children.IntroduceNumber(driver, childrenEntity.Number);
            children.IntroduceStreet(driver, childrenEntity.Street);
            children.IntroduceTown(driver, childrenEntity.Town);
            children.IntroduceCity(driver, childrenEntity.City);

            children.ClickOnSaveChild(driver);

            children.ClickOnNext(driver);

            petsExisting.ClickOnYes(driver);

            pets.IntroduceName(driver, petEntity.Name);
            pets.IntroduceType(driver, petEntity.Type);
            pets.ClickOnSavePet(driver);
            pets.ClickOnNext(driver);

            return driver.Url;
        }

        public string CompleteCustomer_Married_Child_Pet_Correct(IWebDriver driver)
        {
            customerEntity = repository.GetCustomer("Married");
            partnerEntity = repository.GetPartner("Correct");
            childrenEntity = repository.GetChildren("Correct");
            petEntity = repository.GetPet("Correct");

            summary.AccessToStep1(driver);

            customer.IntroduceFirstName(driver, customerEntity.FirstName);
            customer.IntroduceLastName(driver, customerEntity.LastName);
            customer.IntroduceBirthday(driver, customerEntity.Day, customerEntity.Month, customerEntity.Year);
            customer.IntroduceMatitalStatus(driver, customerEntity.MaritalStatus);
            customer.IntroducePostCode(driver, customerEntity.PostCode);
            customer.IntroduceNumber(driver, customerEntity.Address1);
            customer.IntroduceStreet(driver, customerEntity.Address2);
            customer.IntroduceVillage(driver, customerEntity.Town);
            customer.IntroducePhone(driver, customerEntity.Telephone);
            customer.ClickOnNext(driver);

            partner.IntroduceFirstName(driver, partnerEntity.FirstName);
            partner.IntroduceLastName(driver, partnerEntity.LastName);
            partner.IntroduceBirthday(driver, partnerEntity.Day, partnerEntity.Month, partnerEntity.Year);
            partner.IntroducePostCode(driver, partnerEntity.PostCode);
            partner.IntroduceNumber(driver, partnerEntity.Address1);
            partner.IntroduceStreet(driver, partnerEntity.Address2);
            partner.IntroduceVillage(driver, partnerEntity.Town);
            partner.ClickOnNext(driver);

            childrenExisting.ClickOnYes(driver);


            children.AddChild(driver);
            children.IntroduceFirstName(driver, childrenEntity.FirstName);
            children.IntroduceLastName(driver, childrenEntity.LastName);
            children.IntroduceBirthday(driver, childrenEntity.Day, childrenEntity.Month, childrenEntity.Year);
            children.IntroduceRelationship(driver, childrenEntity.Relation);
            children.IntroducePostcode(driver, childrenEntity.PostCode);
            children.IntroduceNumber(driver, childrenEntity.Number);
            children.IntroduceStreet(driver, childrenEntity.Street);
            children.IntroduceTown(driver, childrenEntity.Town);
            children.IntroduceCity(driver, childrenEntity.City);

            children.ClickOnSaveChild(driver);

            children.ClickOnNext(driver);

            petsExisting.ClickOnYes(driver);

            pets.AddPet(driver);
            pets.IntroduceName(driver, petEntity.Name);
            pets.IntroduceType(driver, petEntity.Type);
            pets.ClickOnSavePet(driver);
            pets.ClickOnNext(driver);

            return driver.Url;
        }
    }

    
}
