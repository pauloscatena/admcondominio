namespace AdmCondo.Condo.Domain.ValueObjects
{
    public class Address
    {
        public Address(string addressLine1, string addressLine2, string district, string city, string state, string zipCode)
        {
            SetAddress(addressLine1, addressLine2);
            SetDistrict(district);
            SetCity(city);
            SetState(state);
            SetZipCode(zipCode);
        }

        public string AddressLine1 { get; private set; }
        public string AddressLine2 { get; private set; }    
        public string District { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }

        public void SetAddress(string addressLine1, string addressLine2)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
        }

        public void SetDistrict(string district){
            District = district;
        }

        public void SetCity(string city)
        {
            City = city;
        }

        public void SetState(string state)
        {
            State = state;
        }

        public void SetZipCode(string zipCode)
        {
            ZipCode = zipCode;
        }
    }
}