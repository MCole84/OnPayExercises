using Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.API.Data
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAll();

        Company GetById(int CompanyId);
    }
}
