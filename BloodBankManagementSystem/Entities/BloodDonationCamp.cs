using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodBankManagementSystem.Entities
{
    [Table("BloodDonationCamps")]
    public class BloodDonationCamp
    {
        [Key]
        public int BloodDonationCampID { get; set; }
        [Required]
        public string CampName { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public int BloodBankID { get; set; }
        public DateTime CampStartDate { get; set; }
        public DateTime CampEndDate { get; set; }
    }
}
