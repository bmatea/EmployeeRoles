using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zadatak.Models
{
    public class Initializer
    {
        public static void SeedDatabase(ModelBuilder modelBuilder)
        {
            var initializer = new Initializer();
            initializer.SeedEmployees(modelBuilder);
            initializer.SeedRoles(modelBuilder);
            initializer.SeedUserRoles(modelBuilder);
        }

        private void SeedEmployees(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 1,
                FullName = "Frank Luna",
                Email = "frank.luna@mail.com",
                PhoneNumber = "789-777-356",
                ImageUrl = "avatar1.png"
            }, new Employee
            {
                Id = 2,
                FullName = "Tomas Moller",
                Email = "tomas.moller@mail.com",
                PhoneNumber = "466-222-333",
                ImageUrl = "avatar2.png"
            }, new Employee
            {
                Id = 3,
                FullName = "Eric Haines",
                Email = "eric.haines@mail.com",
                PhoneNumber = "888-999-234",
                ImageUrl = "avatar3.png"
            }, new Employee
            {
                Id = 4,
                FullName = "Thomas E. Cormen",
                Email = "thomas.cormen@mail.com",
                PhoneNumber = "567-222-465",
                ImageUrl = "avatar4.jpg"
            }, new Employee
            {
                Id = 5,
                FullName = "Count Saint Germain",
                Email = "count.saint.germain@mail.com",
                PhoneNumber = "737-922-495",
                ImageUrl = "avatar5.jpg"
            }, new Employee
            {
                Id = 6,
                FullName = "Franz Mesmer",
                Email = "franz.mesmer@mail.com",
                PhoneNumber = "837-555-133",
                ImageUrl = "avatar6.png"
            }, new Employee
            {
                Id = 7,
                FullName = "Erzsebet Bathory",
                Email = "erzsebet.bathory@mail.com",
                PhoneNumber = "666-666-666",
                ImageUrl = "avatar7.jpg"
            }, new Employee
            {
                Id = 8,
                FullName = "Mislav Mihajlovic",
                Email = "mislav.mihajlovic@mail.com",
                PhoneNumber = "123-321-456",
                ImageUrl = "avatar8.png"
            });

        }

        private void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = 1,
                Name = "Admin"
            }, new Role
            {
                Id = 2,
                Name = "User"
            }, new Role
            {
                Id = 3,
                Name = "Guest"
            });
        }

        private void SeedUserRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeRole>().HasData(new EmployeeRole
            {
                EmployeeId = 1,
                RoleId = 1
            }, new EmployeeRole
            {
                EmployeeId = 7,
                RoleId = 1
            }, new EmployeeRole
            {
                EmployeeId = 2,
                RoleId = 2
            }, new EmployeeRole
            {
                EmployeeId = 3,
                RoleId = 2
            }, new EmployeeRole
            {
                EmployeeId = 4,
                RoleId = 3
            }, new EmployeeRole
            {
                EmployeeId = 5,
                RoleId = 2
            }, new EmployeeRole
            {
                EmployeeId = 6,
                RoleId = 3
            }, new EmployeeRole
            {
                EmployeeId = 8,
                RoleId = 2
            });
        }
    }
}
