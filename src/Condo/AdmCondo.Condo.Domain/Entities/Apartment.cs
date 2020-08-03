using System;
using System.Collections.Generic;
using System.Linq;

namespace AdmCondo.Condo.Domain.Entities
{
    public class Apartment
    {
        private List<HouseHold> _households;

        private Apartment()
        {
            _households = new List<HouseHold>();
        }

        public Apartment(Guid id, int number, string floor): this()
        {
            Id = id;
            SetNumber(number);
            SetFloor(floor);
        }
        public Apartment(int number, string floor): this()
        {
            Id = Guid.NewGuid();
            SetNumber(number);
            SetFloor(floor);
        }


        public Guid Id { get; private set; }
        public int Number { get; private set; }
        public string Floor { get; private set; }        
        public IEnumerable<HouseHold> HouseHolds => _households.AsReadOnly();

        public void SetNumber(int number)
        {
            Number = number;
        }

        public void SetFloor(string floor)
        {
            Floor = floor;
        }

        public void AddHouseHold(HouseHold household)
        {
            _households.Add(household);
        }

        public void RemoveHouseHold(Guid houseHoldId)
        {
            var household = _households.FirstOrDefault(h => h.Id == houseHoldId);
            if(household != null)
            {
                _households.Remove(household);
            }
        }

        public void MoveOutPeople()
        {
            _households.Clear();
        }
    }
}