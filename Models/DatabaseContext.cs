using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace zadatak.Models
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                id = 1,
                FullName = "Frank Luna",
                Email = "frank.luna@mail.com",
                PhoneNumber = "789-777-356",
                ImageUrl = "avatar1.png"
            }, new Employee
            {
                id = 2,
                FullName = "Tomas Moller",
                Email = "tomas.moller@mail.com",
                PhoneNumber = "466-222-333",
                ImageUrl = "avatar2.png"
            }, new Employee
            {
                id = 3,
                FullName = "Eric Haines",
                Email = "eric.haines@mail.com",
                PhoneNumber = "888-999-234",
                ImageUrl = "avatar3.png"
            }, new Employee
            {
                id = 4,
                FullName = "Thomas E. Cormen",
                Email = "thomas.cormen@mail.com",
                PhoneNumber = "567-222-465",
                ImageUrl = "avatar4.jpg"
            }, new Employee
            {
                id = 5,
                FullName = "Count Saint Germain",
                Email = "count.saint.germain@mail.com",
                PhoneNumber = "737-922-495",
                ImageUrl = "avatar5.jpg"
            }, new Employee
            {
                id = 6,
                FullName = "Franz Mesmer",
                Email = "franz.mesmer@mail.com",
                PhoneNumber = "837-555-133",
                ImageUrl = "avatar6.png"
            }, new Employee
            {
                id = 7,
                FullName = "Erzsebet Bathory",
                Email = "erzsebet.bathory@mail.com",
                PhoneNumber = "666-666-666",
                ImageUrl = "avatar7.jpg"
            }, new Employee
            {
                id = 8,
                FullName = "Mislav Mihajlovic",
                Email = "mislav.mihajlovic@mail.com",
                PhoneNumber = "123-321-456",
                ImageUrl = "avatar8.png"
            });

            modelBuilder.Entity<Role>().HasData(new Role
            {
                id = 1,
                Name = "Admin"
            }, new Role
            {
                id = 2,
                Name = "User"
            }, new Role
            {
                id = 3,
                Name = "Guest"
            });

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

            modelBuilder.Entity<EmployeeRole>().HasKey(x => new { x.EmployeeId, x.RoleId });
            modelBuilder.Entity<EmployeeRole>().HasOne(er => er.employee).WithMany(e => e.EmployeeRoles).HasForeignKey(er => er.EmployeeId);
            modelBuilder.Entity<EmployeeRole>().HasOne(er => er.role).WithMany(r => r.EmployeeRoles).HasForeignKey(er => er.RoleId);
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
    }
}
