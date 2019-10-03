using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Project.Data.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        
        public string Name { get; set; }

        public string Address { get; set; }

        [NotMapped]
        public IEnumerable<Payment> Payments { get; set; }
    }
}
