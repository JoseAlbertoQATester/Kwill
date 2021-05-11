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
            else if (name == "Correct")
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
            else if (name == "Correct")
            {
                _pet.Name = "Maya";
                _pet.Type = "Dog";
            }
            else 
            {
                _pet.Name = "";
                _pet.Type = "";
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
            else if (name == "Correct")
            {
                _children.FirstName = "Hugo";
                _children.LastName = "Lagos";
                _children.Day = "1";
                _children.Month = "January";
                _children.Year = "2020";
                _children.Number = "731a";
                _children.City = "LONDON";
                _children.Town = "";
                _children.PostCode = "E10 5AB";
                _children.Street = "High Road Leyton";
                _children.Relation = "Son";
            }
            else 
            {
                _children.FirstName = "";
                _children.LastName = "";
                _children.Day = "";
                _children.Month = "";
                _children.Year = "";
                _children.Number = "";
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
            else if (name == "Correct")
            {
                _person.FirstName = "Jonh";
                _person.LastName = "Lagos";
                _person.Relation = "Family Menber";
                _person.Day = "1";
                _person.Month = "January";
                _person.Year = "1990";
                _person.City = "LONDON";
                _person.Town = "";
                _person.PostCode = "E10 5AB";
                _person.Address1 = "731a";
                _person.Address2 = "High Road Leyton";
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
            else if (name == "Correct")
            {
                _partner.FirstName = "Anna";
                _partner.LastName = "Vargas";
                _partner.Day = "25";
                _partner.Month = "Sep";
                _partner.Year = "1995";
                _partner.City = "LONDON";
                _partner.Town = "";
                _partner.PostCode = "E10 5AB";
                _partner.Address1 = "731a";
                _partner.Address2 = "High Road Leyton";
            }
            else if (name == "Younght")
            {
                _partner.FirstName = "Anna";
                _partner.LastName = "Vargas";
                _partner.Day = "25";
                _partner.Month = "Sep";
                _partner.Year = "1995";
                _partner.City = "LONDON";
                _partner.Town = "";
                _partner.PostCode = "E10 5AB";
                _partner.Address1 = "731a";
                _partner.Address2 = "High Road Leyton";
            }

            else
            {
                _partner.FirstName = "";
                _partner.LastName = "";
                _partner.Day = "";
                _partner.Month = "";
                _partner.Year = "";
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
            else if (name == "Married")
            {
                _customer.FirstName = "Jose";
                _customer.LastName = "Lagos";
                _customer.MiddleName = "Alberto";
                _customer.Day = "5";
                _customer.Month = "Aug";
                _customer.Year = "1995";
                _customer.MaritalStatus = "Married";
                _customer.City = "LONDON";
                _customer.Town = "";
                _customer.PostCode = "E10 5AB";
                _customer.Address1 = "731a";
                _customer.Address2 = "High Road Leyton";
                _customer.Telephone = "07700000000";
            }
            else if (name == "Single")
            {
                _customer.FirstName = "Jose";
                _customer.LastName = "Lagos";
                _customer.MiddleName = "Alberto";
                _customer.Day = "5";
                _customer.Month = "Aug";
                _customer.Year = "1995";
                _customer.MaritalStatus = "Single";
                _customer.City = "LONDON";
                _customer.Town = "";
                _customer.PostCode = "E10 5AB";
                _customer.Address1 = "731a";
                _customer.Address2 = "High Road Leyton";
                _customer.Telephone = "07700000000";
            }
            else if (name == "Younght")
            {
                _customer.FirstName = "Jose";
                _customer.LastName = "Lagos";
                _customer.MiddleName = "Alberto";
                _customer.Day = "5";
                _customer.Month = "Aug";
                _customer.Year = "2010";
                _customer.MaritalStatus = "Married";
                _customer.City = "LONDON";
                _customer.Town = "";
                _customer.PostCode = "E10 5AB";
                _customer.Address1 = "731a";
                _customer.Address2 = "High Road Leyton";
                _customer.Telephone = "07700000000";
            }


            else 
            {
                _customer.FirstName = "";
                _customer.LastName = "";
                _customer.MiddleName = "";
                _customer.Day = "";
                _customer.Month = "";
                _customer.Year = "";
                _customer.MaritalStatus = "";
                _customer.City = "";
                _customer.Town = "";
                _customer.PostCode = "";
                _customer.Address1 = "";
                _customer.Address2 = "";
                _customer.Telephone = "";
            }

            return _customer;
        }

        public UserData GetUserData(string name)
        {
            UserData _user = new UserData();
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            else if (name == "Correct")
            {
                _user.Email = "test@test.com";
                _user.Password = "123456";
            }
            else if (name == "admin")
            {
                _user.Email = "admin@kwil.co.uk";
                _user.Password = "18!chicken";
            }
            else
            {
                _user.Email = "";
                _user.Password = "";
            }

            return _user;
        }

    }
}
