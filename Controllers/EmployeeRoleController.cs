using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using zadatak.Models;
using zadatak.Models.DataManager;
using zadatak.Models.Repository;

namespace zadatak.Controllers
{

    [ApiController]
    public class EmployeeRoleController : ControllerBase
    {

        private  IEmployeeRoleRepository repo;

        public EmployeeRoleController(IEmployeeRoleRepository repo)
        {
            this.repo = repo;
        }


        [HttpGet]
        [Route("api/EmployeeRole/All")]
        public IEnumerable<EmployeeRole> Get()
        {
            return repo.GetAll();
        }

        [HttpGet]
        [Route("api/EmployeeRole/GetRolesForEmployee/{id}")]
        public IEnumerable<int> GetRoles(int id)
        {
            return repo.getRolesForEmployee(id);
        }


        [HttpGet]
        [Route("api/EmployeeRole/Get/{id}")]
        public EmployeeRole Get(int id)
        {
            return repo.Get(id);
        }


        [HttpPost]
        [Route("api/EmployeeRole/Create/{employeeId}/{roleId}")]
        public int Post(int employeeId, int roleId)
        {
            return repo.Add(employeeId, roleId);
        }


        [HttpPut]
        [Route("api/EmployeeRole/Edit/{id}")]
        public int Put(int id, [FromBody] EmployeeRole newEmployeeRole)
        {
            EmployeeRole toUpdate = repo.Get(id);
            return repo.Update(toUpdate, newEmployeeRole);
        }


        [HttpDelete]
        [Route("api/EmployeeRole/Delete/{id}")]
        public int Delete(int id)
        {
            return repo.Delete(id);
        }

        [HttpDelete]
        [Route("api/EmployeeRole/Delete/{employeeId}/{roleId}")]
        public int Delete(int employeeId, int roleId)
        {
            return repo.Delete(employeeId, roleId);
        }
    }
}
