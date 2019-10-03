﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Models
{
    public class Company
    {
        public int CompanyId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public IEnumerable<Payment> Payments { get; set; }
    }
}
