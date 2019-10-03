using Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.API.Data
{
    public class ICompanyRepository
    {
        public IEnumerable<Company> GetAll();

        public Company GetById(int CompanyId);
    }
}
