using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BloodBankManagementSystem.Entities
{
    [Table("Hospital")]
    public class Hospital
    {
        [Key]
        //Intializing Properties Of Hospital
        public int HospitalID { get; set; }
        [Required]
        public string HospitalName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ContactNo { get; set; }

    }
}


