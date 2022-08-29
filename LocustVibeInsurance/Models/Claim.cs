using System;

namespace LocustVibeInsurance.Models
{
    public class Claim
    {
        public int ClaimID { get; set; }
        public int ClaimNumber { get; set; }
        public DateTime ClaimDate { get; set; }
        public string Description { get; set; }
        public int CustomerID { get; set; }
        public int InsuranceTypeID { get; set; }

        public Customer Customer { get; set; }
        public InsuranceType InsuranceType { get; set; }
    }
}
