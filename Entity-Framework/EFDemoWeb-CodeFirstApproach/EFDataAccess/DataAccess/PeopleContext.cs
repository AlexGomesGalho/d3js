using System;
using System.Collections.Generic;
using System.Text;
using EFDataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDataAccess.DataAccess
{
    public class PeopleContext: DbContext
    {
        public PeopleContext(DbContextOptions Options) : base(Options) { }

        public DbSet<Person> People { get; set; }
        public DbSet<Email> EmailAddress { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
