using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.API.Data;
using Project.Data.Models;

namespace Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyRepository _repository;

        public CompaniesController(ICompanyRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Company>> Get()
        {
            return _repository.GetAll().ToList();
        }
    }
}