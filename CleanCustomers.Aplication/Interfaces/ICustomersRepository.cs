using CleanCustomers.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCustomers.Aplication.Interfaces
{
    public interface ICustomersRepository
    {
        List<Customers> GetAllCustomers();
        Customers GetCustomersById(int id);
        Customers CreateCustomers(Customers customers);
        void UpdateCustomer(Customers customers);
        void DeleteCustomer(int id);
    }
}
