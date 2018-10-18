﻿using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.NewDb
{
    public class PeopleContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=PeopleDatabase;Trusted_Connection=True;");
        }
    }

  
}