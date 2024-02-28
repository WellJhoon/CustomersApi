using CleanCustomers.Aplication.Interfaces;
using CleanCustomers.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCustomers.Infraestructure.Repository
{
    public class CustomersRepository : ICustomersRepository
    {
        public static List<Customers> customers = new List<Customers>()
        {
            new Customers{CustomerId = 1, FirstName = "Jhon", LastName = "Medina", Email = "jhon.43769@gmail.com" , Address = "Duarte #2", PhoneNumber = "829-396-4502", LastPurchaseDate = DateTime.Now, RegistrationDate = new DateTime(2024,2,28,15,30,0)},
        };
    }
}
