using System;
using System.Collections.Generic;
using System.Linq;
using AdmCondo.Condo.Domain.ValueObjects;

namespace AdmCondo.Condo.Domain.Entities
{
    public class Complex
    {
        private List<Block> _blocks;

        private Complex(){
            _blocks = new List<Block>();
        }

        public Complex(
            Guid id, 
            string name, 
            Address address): this()
        {
            Id = id;
            SetName(name);
            Address = address;
        }

        public Complex(
            string name, 
            Address address): this()
        {
            Id = Guid.NewGuid();
            SetName(name);
            Address = address;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public Address Address{ get; private set;}


        public IEnumerable<Block> Blocks => _blocks.AsReadOnly();

        public void SetName(string newName)
        {
            Name = newName;
        }        

        public void AddBlock(Block block)
        {
            _blocks.Add(block);
        }

        public void RemoveBlock(Guid blockId)
        {
            var block = _blocks.FirstOrDefault(b => b.Id == blockId);
            if(block != null)
            {
                _blocks.Remove(block);
            }
        }
    }
}
