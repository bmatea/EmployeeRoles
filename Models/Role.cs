using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace zadatak.Models
{
    public class Role
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<EmployeeRole> EmployeeRoles { get; set; }
    }
}
