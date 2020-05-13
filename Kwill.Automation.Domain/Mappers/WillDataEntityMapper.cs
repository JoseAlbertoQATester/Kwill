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


    }
}
