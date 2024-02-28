using CleanCustomers.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCustomers.Aplication.Interfaces
{
    public interface ICustomersService
    {
        List<Customers> GetAllCustomers();
        Customers CreateCustomers (Customers customers);
        Customers GetCustomersById(int id);
        void UpdateCustomers(Customers customers);
        void DeleteCustomers(int id);
    
    }
}
