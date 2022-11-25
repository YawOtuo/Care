using Microsoft.EntityFrameworkCore;
using Care.Models;

namespace Care.DBContexts
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options) : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }


    }
}