﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using zadatak.Configuration;

namespace zadatak.Models
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            Initializer.SeedDatabase(modelBuilder);

            // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeRoleConfiguration());
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
    }
}
