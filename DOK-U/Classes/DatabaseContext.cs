﻿using Microsoft.EntityFrameworkCore;


namespace DOK_U.Classes
{
    internal class DatabaseContext : DbContext
    {
        public DbSet<Person> Users { get; set; } = null!;
        public DbSet<Group> Groups { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=doku.db");
        }
    }
}
