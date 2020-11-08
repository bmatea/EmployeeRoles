using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zadatak.Models.Repository
{
    public interface IEmployeeRoleRepository : IDataRepository<EmployeeRole>
    {
        IEnumerable<int> getRolesForEmployee(int employeeId);

        int Add(int employeeId, int roleId);
        int Delete(int employeeId, int roleId);
    }
}
