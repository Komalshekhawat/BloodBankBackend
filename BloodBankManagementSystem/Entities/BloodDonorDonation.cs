using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodBankManagementSystem.Entities
{

    [Table("BloodDonorDonations")]
    public class BloodDonorDonation
    {
        [Key]
        public int BloodDonationID { get; set; }

        [ForeignKey("BloodDonor")]
        public int BloodDonorID { get; set; }
        public DateTime BloodDonationDate { get; set; }
        public int NumberofBottles { get; set; }
        public int Weight { get; set; }
        public int HBCount { get; set; }

        
    }
}
