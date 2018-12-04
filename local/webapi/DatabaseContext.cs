using System;
using Microsoft.EntityFrameworkCore;
using webapi.Model;

namespace webapi
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public DatabaseContext(DbContextOptions options)
            : base(options) { }
    }
}