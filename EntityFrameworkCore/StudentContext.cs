﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore
{
    // EF Core getting started
    // https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli
    internal class StudentContext : DbContext
    {
        public StudentContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Database = The desired name for the database
            // Server = The server we are connecting to. LocalDB is included with VS
            // Trusted_Connection - Indicates that our windows account should be used
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample;Trusted_Connection=True;");
        }
        
        // Tell EF Core to track Students in the database
        public DbSet<Student> Students { get; set; }
    }
}
