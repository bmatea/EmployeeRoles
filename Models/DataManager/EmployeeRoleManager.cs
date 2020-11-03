using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using zadatak.Models.Repository;

namespace zadatak.Models.DataManager
{
    public class EmployeeRoleManager : IDataRepository<EmployeeRole>
    {
        readonly DatabaseContext context;

        public EmployeeRoleManager(DatabaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<EmployeeRole> GetAll()
        {
            try
            {
                return context.EmployeeRoles.ToList();
            }
            catch
            {
                throw;
            }
        }

        public int Add(EmployeeRole employeeRole)
        {
            try
            {
                context.EmployeeRoles.Add(employeeRole);
                context.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        public int Add(int employeeId, int roleId)
        {
            try
            {
                EmployeeRole er = new EmployeeRole { EmployeeId = employeeId, RoleId = roleId };
                var res = context.EmployeeRoles.Add(er);
                context.SaveChanges();

                return 1;
            } catch
            {
                throw;
            }
        }

        public int Update(EmployeeRole employeeRole, EmployeeRole newEmployeeRole)
        {
            try
            {
                employeeRole.EmployeeId = newEmployeeRole.EmployeeId;
                employeeRole.employee = newEmployeeRole.employee;
                employeeRole.RoleId = newEmployeeRole.RoleId;
                employeeRole.role = newEmployeeRole.role;

                context.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        public EmployeeRole Get(int id)
        {
            try
            {
                EmployeeRole employeeRole = context.EmployeeRoles.Find(id);

                return employeeRole;
            }
            catch
            {
                throw;
            }
        }

        public List<int> GetRolesForEmployee(int employeeId)
        {
            try
            {
                List<EmployeeRole> ers = context.EmployeeRoles.Where(er => er.EmployeeId == employeeId).ToList<EmployeeRole>();
                var roleIds = new List<int>();
                foreach(var er in ers)
                {
                    roleIds.Add(er.RoleId);
                }
                return roleIds;
            } catch
            {
                throw;
            }
        }

        public int Delete(int id)
        {
            try
            {
                EmployeeRole employeeRole = context.EmployeeRoles.Find(id);
                context.EmployeeRoles.Remove(employeeRole);
                context.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        public int Delete(int employeeId, int roleId)
        {
            try
            {
                EmployeeRole er = context.EmployeeRoles.Where(er => (er.EmployeeId == employeeId) && (er.RoleId == roleId)).FirstOrDefault();
                context.EmployeeRoles.Remove(er);
                context.SaveChanges();
                return 1;
            } catch
            {
                throw;
            }
        }
    }
}
