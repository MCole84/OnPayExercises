using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Project.Data.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        public string CheckNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckDate { get; set; }

        [DataType(DataType.Currency)]
        public decimal CheckAmount { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }

        public Company Company { get; set; }

        [ForeignKey("Vendor")]
        public int VendorId { get; set; }

        public Vendor Vendor { get; set; }

        public IEnumerable<string> Invoices { get; set; }
    }
}
