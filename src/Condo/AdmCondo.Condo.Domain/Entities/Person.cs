using System;
using AdmCondo.Condo.Domain.ValueObjects;

namespace AdmCondo.Condo.Domain.Entities
{
    public abstract class Person
    {
        private Person()
        {
        }

        public Person(Guid id, string name, Document document): this()
        {
            Id = id;
            SetName(name);
            SetDocument(document);
        }

        public Person(string name, Document document): this()
        {
            Id = Guid.NewGuid();
            SetName(name);
            SetDocument(document);
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public Document Document { get; private set; }        

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetDocument(Document document)
        {
            Document = document;
        }
    }
}