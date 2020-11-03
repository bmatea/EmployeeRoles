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
    public class RoleController : ControllerBase
    {

        private readonly IDataRepository<Role> dal;

        public RoleController(IDataRepository<Role> repo)
        {
            this.dal = repo;
        }


        [HttpGet]
        [Route("api/Role/All")]
        public IEnumerable<Role> Get()
        {
            return dal.GetAll();
        }


        [HttpGet]
        [Route("api/Role/Get/{id}")]
        public Role Get(int id)
        {
            return dal.Get(id);
        }


        [HttpPost]
        [Route("api/Role/Create/{id}")]
        public int Post(Role role)
        {
            return dal.Add(role);
        }


        [HttpPut]
        [Route("api/Role/Edit/{id}")]
        public int Put(int id, [FromBody] Role newRole)
        {
            Role toUpdate = dal.Get(id);
            return dal.Update(toUpdate, newRole);
        }


        [HttpDelete]
        [Route("api/Role/Delete/{id}")]
        public int Delete(int id)
        {
            return dal.Delete(id);
        }
    }
}
