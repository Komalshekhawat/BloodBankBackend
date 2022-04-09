using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodBankManagementSystem.Entities
{
    [Table("BloodInventories")]
    public class BloodInventory
    {
        [Key]
        public int BloodInventoryID { get; set; }
        [Required]
        [StringLength(5)]
        public string BloodGroup { get; set; }
        public int NumberofBottles { get; set; }
        public int BloodBankID { get; set; }
        public DateTime ExpiryDate { get; set; }

    }
}
