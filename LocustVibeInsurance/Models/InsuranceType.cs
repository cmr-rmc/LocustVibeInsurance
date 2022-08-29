using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocustVibeInsurance.Models
{
    public class InsuranceType
    {
        public int InsuranceTypeID { get; set; }
        public string InsuranceTypeName { get; set; }

        public ICollection<Claim> Claims { get; set; }
    }
}
