using CleanCustomers.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCustomers.Infraestructure.Context
{
    public class CustomersDbContext : DbContext
    {
        public CustomersDbContext(DbContextOptions<CustomersDbContext> options) : base(options) 
        {
        }

        public DbSet<Customers> Customers { get; set; }
    }
}
