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

        public IList<string> InvoiceNumbers { get; set; }

        public IList<DateTime> InvoiceDate { get; set; }

        public IList<decimal> InvoiceAmounts { get; set; }

        
    }
}
