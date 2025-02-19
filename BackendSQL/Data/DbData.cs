using BackendSQL.Models; // imports our models with Employee, Address, and Contact for use later
using Microsoft.EntityFrameworkCore;
namespace BackendSQL.Data
{
    public class DbData : DbContext // DbContext acts as "the bridge" between our application and our database
    {
        public DbData(DbContextOptions<DbData> options) : base(options) 
        { 
            public DbSet<EmployeeModel> Employee { get; set; } // creates a table Employee based off the model
            public DbSet<AddressModel> Address { get; set; } // creates a table Address based off the model
        public DbSet<ContactModel> Contact { get; set; } // creates a table Contact based off the model

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
