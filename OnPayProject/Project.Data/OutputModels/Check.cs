using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.OutputModels
{
    public class Check
    {
        public string CheckNumber { get; set; }

        public DateTime CheckDate { get; set; }

        public decimal CheckAmount { get; set; }

        public int VendorNumber { get; set; }

        public string VendorAddress { get; set; }

        public IEnumerable<string> InvoiceNumbers { get; set; }

        public IEnumerable<DateTime> InvoiceDate { get; set; }

        public IEnumerable<decimal> InvoiceAmounts { get; set; }

        
    }
}
