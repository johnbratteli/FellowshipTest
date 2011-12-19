using System.ComponentModel.DataAnnotations;
using FellowshipTest.Models;

namespace FellowshipTest.ViewModels
{
    public class AddressView
    {
        public Address Addr { get; set; }

        public AddressView()
        {
            Addr = new Address();
        }

        public AddressView(string personID, string personURI, AddressType addrType)
        {
            Addr = new Address(personID, personID, addrType);
        }
        /*
        public static implicit operator AddressView(Address addr)
        {
            var personID = addr.person.id;
            var personURI = addr.person.uri;
            var addressType = addr.addressType;

            return new AddressView(personID, personURI, addressType);
        }
        */
        public static explicit operator AddressView(Address addr)
        {
            var personID = addr.person.id;
            var personURI = addr.person.uri;
            var addressType = addr.addressType;

            return new AddressView(personID, personURI, addressType);
        }
    }
}