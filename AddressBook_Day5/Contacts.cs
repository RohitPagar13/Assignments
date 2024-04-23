using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Day5
{
    internal class Contacts
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private long zip;
        private long phone;
        private string email;

        public Contacts(string firstName, string lastName, string address, string city, string state, long zip, long phone, string email) { 
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phone = phone;
            this.email = email;
        }


    }
}
