using Kwill.Automation.Domain.Mappers;
using Kwill.Automation.Domain.Entities;
using Kwill.Automation.Data.Data;
using Kwill.Automation.Data.Entities;

namespace Kwill.Automation.Domain.Repository
{
    public class Repository
    {
        public KwillData data = new KwillData();

        public PetData petdata = new PetData();

        public ChildrenData childrenData = new ChildrenData();

        public PartnerData partnerdata = new PartnerData();

        public PersonData persondata = new PersonData();

        public CustomerData customerdata = new CustomerData();



        public WillDataEntityMapper kWillMapper = new WillDataEntityMapper();


        public WillEntity GetWill(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new System.ArgumentNullException(nameof(name));
            }

            return kWillMapper.MapFrom(data.GetWillData(name));
        }

        public PetEntity GetPet(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new System.ArgumentNullException(nameof(name));
            }

            return kWillMapper.MapFrom(data.GetPetData(name));
        }

        public ChildrenEntity GetChildren(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new System.ArgumentNullException(nameof(name));
            }

            return kWillMapper.MapFrom(data.GetChildrenData(name));
        }

        public PersonEntity GetPerson(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new System.ArgumentNullException(nameof(name));
            }

            return kWillMapper.MapFrom(data.GetPersonData(name));
        }

        public PartnerEntity GetPartner(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new System.ArgumentNullException(nameof(name));
            }

            return kWillMapper.MapFrom(data.GetPartnerData(name));
        }


        public CustomerEntity GetCustomer(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new System.ArgumentNullException(nameof(name));
            }

            return kWillMapper.MapFrom(data.GetCustomerData(name));
        }

    }
}
