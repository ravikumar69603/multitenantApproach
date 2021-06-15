using AppMultTenant.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMultTenant.Data
{
    public class MasterDataContext : DbContext
    {
        public MasterDataContext(DbContextOptions<MasterDataContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
