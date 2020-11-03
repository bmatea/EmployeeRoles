using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zadatak.Models.Repository;

namespace zadatak.Models.DataManager
{
    public class EmployeeManager : IDataRepository<Employee>
    {
        readonly DatabaseContext context;

        public EmployeeManager(DatabaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            try
            {
                return context.Employees.ToList();
            }
            catch
            {
                throw;
            }
        }

        public int Add(Employee employee)
        {
            try
            {
                context.Employees.Add(employee);
                context.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        public int Update(Employee employee, Employee newEmployee)
        {
            try
            {
                employee.FullName = newEmployee.FullName;
                employee.Email = newEmployee.Email;
                employee.PhoneNumber = newEmployee.PhoneNumber;
                employee.ImageUrl = newEmployee.ImageUrl;

                context.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        public Employee Get(int id)
        {
            try
            {
                Employee employee = context.Employees.Find(id);

                return employee;
            }
            catch
            {
                throw;
            }
        }

        public int Delete(int id)
        {
            try
            {
                Employee employee = context.Employees.Find(id);
                context.Employees.Remove(employee);
                context.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }
    }
}
