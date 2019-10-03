using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Data.Models
{
    public class Vendor
    {
        [Key]
        public int VendorId { get; set; }
    }
}
