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

        public ChildrenData GetChildreData(string name)
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
                _children.Month=1;
                _children.Year = 2020;
                _children.Number =10;
                _children.City = "";
                _children.Town = "";
                _children.PostCode="";
                _children.Street = "";
                _children.Relation = "";
            }

            return _children;
        }

    }
}
