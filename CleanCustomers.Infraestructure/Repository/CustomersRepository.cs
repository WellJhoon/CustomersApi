using CleanCustomers.Aplication.Interfaces;
using CleanCustomers.Domain.Models;
using CleanCustomers.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;


namespace CleanCustomers.Infraestructure.Repository
{
    public class CustomersRepository : ICustomersRepository
    {
        public static List<Customers> customers = new List<Customers>()
        {
            new Customers{Id = 1, FirstName = "Jhon", LastName = "Medina", Email = "jhon.43769@gmail.com" , Address = "Duarte #2", PhoneNumber = "829-396-4502", LastPurchaseDate = DateTime.Now, RegistrationDate = new DateTime(2024,2,28,15,30,0)},
        };
        private readonly CustomersDbContext _customersDbContext;

        public CustomersRepository(CustomersDbContext customersDbContext)
        {
            _customersDbContext = customersDbContext;
        }

        public Customers CreateCustomers(Customers customers)
        {
            _customersDbContext.Customers.Add(customers);
            _customersDbContext.SaveChanges();
            return customers;
        }

        public List<Customers> GetAllCustomers() 
        {
            return _customersDbContext.Customers.ToList();
        }

        public Customers GetCustomersById(int Id)
        {
            return _customersDbContext.Customers.FirstOrDefault(p => p.Id == Id);
        }

        public void UpdateCustomer(Customers customers)
        {
            _customersDbContext.Entry(customers).State = EntityState.Modified;
            _customersDbContext.SaveChanges();
        }

        public void DeleteCustomer(int Id) 
        {
            var customerToDelete = _customersDbContext.Customers.FirstOrDefault(p => p.Id == Id);
            if (customerToDelete != null)
            {
                _customersDbContext.Customers.Remove(customerToDelete);
                _customersDbContext.SaveChanges();
            }
        }
    }
}
