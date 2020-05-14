using Kwill.Automation.Domain.Entities;
using Kwill.Automation.Data.Entities;


namespace Kwill.Automation.Domain.Mappers
{
    public class WillDataEntityMapper
    {
        public WillEntity MapFrom(WillData input)
        {
            if (input == null)
            {
                throw new System.ArgumentNullException(nameof(input));
            }

            return new WillEntity
            {
                Date = input.Date
            };
        }

        public PetEntity MapFrom(PetData input)
        {
            if (input == null)
            {
                throw new System.ArgumentNullException(nameof(input));
            }

            return new PetEntity
            {
                Name = input.Name,
                Type = input.Type
            };
        }

        public ChildrenEntity MapFrom(ChildrenData input)
        {
            if (input == null)
            {
                throw new System.ArgumentNullException(nameof(input));
            }

            return new ChildrenEntity
            {
                FirstName = input.FirstName = "",
                LastName = input.LastName = "",
                Relation = input.Relation = "",
                Day = input.Day = 1,
                Month = input.Month = 1,
                Year = input.Year = 2020,
                Number = input.Number = 10,
                PostCode = input.PostCode = "",
                Street = input.Street = "",
                Town = input.Town = "",
                City = input.City = "",
            };
        }

        public CustomerEntity MapFrom(CustomerData input)
        {
            if (input == null)
            {
                throw new System.ArgumentNullException(nameof(input));
            }

            return new CustomerEntity
            {
                FirstName = input.FirstName = "",
                LastName = input.LastName = "",
                MiddleName = input.MiddleName = "",
                Day = input.Day = 1,
                Month = input.Month = 1,
                Year = input.Year = 2020,
                MaritalStatus = input.MaritalStatus = "",
                PostCode = input.PostCode = "",
                Address1 = input.Address1 = "",
                Address2 = input.Address2 = "",
                Town = input.Town = "",
                City = input.City = "",
                Telephone = input.Telephone = 666666666,
            };
        }

        public PartnerEntity MapFrom(PartnerData input)
        {
            if (input == null)
            {
                throw new System.ArgumentNullException(nameof(input));
            }

            return new PartnerEntity
            {
                FirstName = input.FirstName = "",
                LastName = input.LastName = "",
                Day = input.Day = 1,
                Month = input.Month = 1,
                Year = input.Year = 2020,
                PostCode = input.PostCode = "",
                Address1 = input.Address1 = "",
                Address2 = input.Address2 = "",
                Town = input.Town = "",
                City = input.City = "",
            };
        }


        public PersonEntity MapFrom(PersonData input)
        {
            if (input == null)
            {
                throw new System.ArgumentNullException(nameof(input));
            }

            return new PersonEntity
            {
                FirstName = input.FirstName = "",
                LastName = input.LastName = "",
                Relation = input.Relation = "",
                Day = input.Day = 1,
                Month = input.Month = 1,
                Year = input.Year = 2020,
                PostCode = input.PostCode = "",
                Address1 = input.Address1 = "",
                Address2 = input.Address2 = "",
                Town = input.Town = "",
                City = input.City = "",
            };
        }


    }
}
