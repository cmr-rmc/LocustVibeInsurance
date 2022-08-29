using System.Diagnostics;
using System;
using LocustVibeInsurance.Models;
using System.Linq;

namespace LocustVibeInsurance.Data
{
    public class InitializeData
    {
        public static void Initialize(LocustVibeInsuranceContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Customer.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
            new Customer{FirstName="Albert",LastName="Camus",Address="123 Address",City="New York City", State="NY",PostalCode="10001", PhoneNumber="3031234567", BirthDate=DateTime.Parse("1913-11-07")},
            new Customer{FirstName="Stephen",LastName="King",Address="666 Horror Avenue",City="Derry", State="ME",PostalCode="03038", PhoneNumber="7201234567", BirthDate=DateTime.Parse("1947-09-21")},
            new Customer{FirstName="Tom",LastName="Robbins",Address="567 Blues Street",City="La Conner", State="WA",PostalCode="03038", PhoneNumber="7201234567", BirthDate=DateTime.Parse("1932-07-22")}
            };
            foreach (Customer customer in customers)
            {
                context.Customer.Add(customer);
            }
            context.SaveChanges();

            var insuranceTypes = new InsuranceType[]
            {
            new InsuranceType{InsuranceTypeName="Auto"},
            new InsuranceType{InsuranceTypeName="Health"},
            new InsuranceType{InsuranceTypeName="Life"}
            };
            foreach (InsuranceType insuranceType in insuranceTypes)
            {
                context.InsuranceType.Add(insuranceType);
            }
            context.SaveChanges();

            var claims = new Claim[]
            {
            new Claim{CustomerID=1,InsuranceTypeID=1,ClaimDate=DateTime.Parse("2022-01-12"),ClaimNumber=1234,Description="Accident"},
            new Claim{CustomerID=2,InsuranceTypeID=2,ClaimDate=DateTime.Parse("2021-05-02"),ClaimNumber=4567,Description="Medical Emergency"},
            new Claim{CustomerID=3,InsuranceTypeID=3,ClaimDate=DateTime.Parse("2020-07-04"),ClaimNumber=4567,Description="Passing"},
            };
            foreach (Claim claim in claims)
            {
                context.Claims.Add(claim);
            }
            context.SaveChanges();
        }
    }
}
