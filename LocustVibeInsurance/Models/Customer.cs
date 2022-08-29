using System.Collections.Generic;
using System;

namespace LocustVibeInsurance.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<Claim> Claims { get; set; }

    }
}
