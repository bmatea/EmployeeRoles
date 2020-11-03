using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zadatak.Models
{
    public class EmployeeRole
    {

        public int EmployeeId { get; set; }
        public Employee employee { get; set; }

        public int RoleId { get; set; }
        public Role role { get; set; }
    }
}
