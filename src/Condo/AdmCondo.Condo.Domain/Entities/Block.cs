using System;
using System.Collections.Generic;
using System.Linq;

namespace AdmCondo.Condo.Domain.Entities
{
    public class Block
    {
        private List<Apartment> _apartments;

        private Block()
        {
            _apartments = new List<Apartment>();
        }

        public Block(Guid id, string name, string identifier): this()
        {
            Id = id;
            SetName(name);
            SetIdentifier(identifier);
        }
        public Block(string name, string identifier): this()
        {
            Id = Guid.NewGuid();
            SetName(name);
            SetIdentifier(identifier);
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Identifier { get; private set; }
        public IEnumerable<Apartment> Apartments => _apartments.AsReadOnly();

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetIdentifier(string identifier)
        {
            Identifier = identifier;
        }

        public void AddApartment(Apartment apartment)
        {
            _apartments.Add(apartment);
        }

        public void RemoveApartment(Guid apartmentId)
        {
            var apartment = _apartments.FirstOrDefault(r => r.Id == apartmentId);
            if(apartment != null)
            {
                _apartments.Remove(apartment);
            }
        }
    }
}