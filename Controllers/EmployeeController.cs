using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using zadatak.Models;
using zadatak.Models.Repository;

namespace zadatak.Controllers
{
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IDataRepository<Employee> dal;

        public EmployeeController(IDataRepository<Employee> repo)
        {
            this.dal = repo;
        }

       
        [HttpGet]
        [Route("api/Employee/All")]
        public IEnumerable<Employee> Get()
        {
            return dal.GetAll();
        }

       
        [HttpGet]
        [Route("api/Employee/Get/{id}")]
        public Employee Get(int id)
        {
            return dal.Get(id);
        }

       
        [HttpPost]
        [Route("api/Employee/Create/{id}")]
        public int Post(Employee employee)
        {
            return dal.Add(employee);
        }

       
        [HttpPut]
        [Route("api/Employee/Edit/{id}")]
        public int Put(int id, [FromBody] Employee newEmployee)
        {
            Employee toUpdate = dal.Get(id);
            return dal.Update(toUpdate, newEmployee);
        }

       
        [HttpDelete]
        [Route("api/Employee/Delete/{id}")]
        public int Delete(int id)
        {
            return dal.Delete(id);
        }
    }
}
