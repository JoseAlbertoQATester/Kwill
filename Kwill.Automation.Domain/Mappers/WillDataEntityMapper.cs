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
                FirstName = input.FirstName ,
                LastName = input.LastName ,
                Relation = input.Relation ,
                Day = input.Day ,
                Month = input.Month ,
                Year = input.Year ,
                Number = input.Number ,
                PostCode = input.PostCode ,
                Street = input.Street ,
                Town = input.Town ,
                City = input.City ,
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
                FirstName = input.FirstName ,
                LastName = input.LastName ,
                MiddleName = input.MiddleName ,
                Day = input.Day ,
                Month = input.Month ,
                Year = input.Year ,
                MaritalStatus = input.MaritalStatus ,
                PostCode = input.PostCode ,
                Address1 = input.Address1 ,
                Address2 = input.Address2 ,
                Town = input.Town ,
                City = input.City ,
                Telephone = input.Telephone ,
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
                FirstName = input.FirstName ,
                LastName = input.LastName ,
                Day = input.Day ,
                Month = input.Month ,
                Year = input.Year ,
                PostCode = input.PostCode ,
                Address1 = input.Address1 ,
                Address2 = input.Address2 ,
                Town = input.Town ,
                City = input.City ,
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
                FirstName = input.FirstName ,
                LastName = input.LastName ,
                Relation = input.Relation ,
                Day = input.Day ,
                Month = input.Month ,
                Year = input.Year ,
                PostCode = input.PostCode ,
                Address1 = input.Address1 ,
                Address2 = input.Address2 ,
                Town = input.Town ,
                City = input.City ,
            };
        }
        public UserEntity MapFrom(UserData input)
        {
            if (input == null)
            {
                throw new System.ArgumentNullException(nameof(input));
            }

            return new UserEntity
            {
                Email = input.Email,
                Password = input.Password,
            };
        }


    }
}
