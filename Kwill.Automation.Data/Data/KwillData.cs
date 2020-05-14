using Kwill.Automation.Data.Entities;
using System;

namespace Kwill.Automation.Data.Data
{
    public class KwillData
    {
        public WillData GetWillData(string name)
        {
            WillData _will = new WillData();
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            else if (name == "payPool")
            {
                _will.Date = "InviteEdit Leave";
            }

            return _will;
        }

        public PetData GetPetData(string name)
        {
            PetData _pet = new PetData();
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            else if (name == "payPool")
            {
                _pet.Name = "Maya";
                _pet.Type = "Dog";
            }

            return _pet;
        }

        public ChildrenData GetChildrenData(string name)
        {
            ChildrenData _children = new ChildrenData();
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            else if (name == "payPool")
            {
                _children.FirstName = "Maya";
                _children.LastName = "Dog";
                _children.Day = 1;
                _children.Month = 1;
                _children.Year = 2020;
                _children.Number = 10;
                _children.City = "";
                _children.Town = "";
                _children.PostCode = "";
                _children.Street = "";
                _children.Relation = "";
            }

            return _children;
        }

        public PersonData GetPersonData(string name)
        {
            PersonData _person = new PersonData();
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            else if (name == "payPool")
            {
                _person.FirstName = "Maya";
                _person.LastName = "Dog";
                _person.Relation = "Dog";
                _person.Day = 1;
                _person.Month = 1;
                _person.Year = 2020;
                _person.City = "";
                _person.Town = "";
                _person.PostCode = "";
                _person.Address1 = "";
                _person.Address2 = "";
            }

            return _person;
        }

        public PartnerData GetPartnerData(string name)
        {
            PartnerData _partner = new PartnerData();
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            else if (name == "payPool")
            {
                _partner.FirstName = "Maya";
                _partner.LastName = "Dog";
                _partner.Day = 1;
                _partner.Month = 1;
                _partner.Year = 2020;
                _partner.City = "";
                _partner.Town = "";
                _partner.PostCode = "";
                _partner.Address1 = "";
                _partner.Address2 = "";
            }

            return _partner;
        }

        public CustomerData GetCustomerData(string name)
        {
            CustomerData _customer = new CustomerData();
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            else if (name == "payPool")
            {
                _customer.FirstName = "Maya";
                _customer.LastName = "Dog";
                _customer.MiddleName = "Dog";
                _customer.Day = 1;
                _customer.Month = 1;
                _customer.Year = 2020;
                _customer.MaritalStatus = "";
                _customer.City = "";
                _customer.Town = "";
                _customer.PostCode = "";
                _customer.Address1 = "";
                _customer.Address2 = "";
                _customer.Telephone = 666666666;
            }

            return _customer;
        }

    }
}
