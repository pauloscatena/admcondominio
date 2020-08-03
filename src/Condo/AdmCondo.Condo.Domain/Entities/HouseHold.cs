using System;
using AdmCondo.Condo.Domain.ValueObjects;

namespace AdmCondo.Condo.Domain.Entities
{
    public class HouseHold: Person
    {
        public HouseHold(Guid id, string name, Document document, DateTime? birthDate) 
        : base(id, name, document)
        {
            SetBirthDate(birthDate);
        }

        public HouseHold(string name, Document document, DateTime? birthDate) 
        : base(name, document)
        {
            SetBirthDate(birthDate);
        }

        public DateTime? BirthDate { get; private set; } 

        public void SetBirthDate(DateTime? birthDate)
        {
            BirthDate = birthDate;
        }

    }
}