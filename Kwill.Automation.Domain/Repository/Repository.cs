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

        public PetData petdata = new PetData();

        public PetData petdata = new PetData();

        public PetData petdata = new PetData();



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

    }
}
