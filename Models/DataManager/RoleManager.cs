using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zadatak.Models.Repository;

namespace zadatak.Models.DataManager
{
    public class RoleManager : IDataRepository<Role>
    {
        readonly DatabaseContext context;

        public RoleManager(DatabaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Role> GetAll()
        {
            try
            {
                return context.Roles.ToList();
            }
            catch
            {
                throw;
            }
        }

        public int Add(Role role)
        {
            try
            {
                context.Roles.Add(role);
                context.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        public int Update(Role role, Role newRole)
        {
            try
            {
                role.Name = newRole.Name;
              

                context.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        public Role Get(int id)
        {
            try
            {
                Role role = context.Roles.Find(id);

                return role;
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
                Role role = context.Roles.Find(id);
                context.Roles.Remove(role);
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
