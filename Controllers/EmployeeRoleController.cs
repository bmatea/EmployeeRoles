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

        private  IDataRepository<EmployeeRole> dal;

        public EmployeeRoleController(IDataRepository<EmployeeRole> repo)
        {
            this.dal = repo;
        }


        [HttpGet]
        [Route("api/EmployeeRole/All")]
        public IEnumerable<EmployeeRole> Get()
        {
            return dal.GetAll();
        }

        [HttpGet]
        [Route("api/EmployeeRole/GetRolesForEmployee/{id}")]
        public IEnumerable<int> GetRoles(int id)
        {
            EmployeeRoleManager erm = (EmployeeRoleManager)dal;
            return erm.GetRolesForEmployee(id);
        }


        [HttpGet]
        [Route("api/EmployeeRole/Get/{id}")]
        public EmployeeRole Get(int id)
        {
            return dal.Get(id);
        }


        [HttpPost]
        [Route("api/EmployeeRole/Create/{employeeId}/{roleId}")]
        public int Post(int employeeId, int roleId)
        {
            EmployeeRoleManager erm = (EmployeeRoleManager)dal;
            return erm.Add(employeeId, roleId);
        }


        [HttpPut]
        [Route("api/EmployeeRole/Edit/{id}")]
        public int Put(int id, [FromBody] EmployeeRole newEmployeeRole)
        {
            EmployeeRole toUpdate = dal.Get(id);
            return dal.Update(toUpdate, newEmployeeRole);
        }


        [HttpDelete]
        [Route("api/EmployeeRole/Delete/{id}")]
        public int Delete(int id)
        {
            return dal.Delete(id);
        }

        [HttpDelete]
        [Route("api/EmployeeRole/Delete/{employeeId}/{roleId}")]
        public int Delete(int employeeId, int roleId)
        {
            EmployeeRoleManager erm = (EmployeeRoleManager)dal;
            return erm.Delete(employeeId, roleId);
        }
    }
}
