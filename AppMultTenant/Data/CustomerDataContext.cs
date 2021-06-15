using AppMultTenant.Model;
using Microsoft.EntityFrameworkCore;


namespace AppMultTenant.Data
{
    public class CustomerDataContext : DbContext
    {
        public CustomerDataContext(DbContextOptions<CustomerDataContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
