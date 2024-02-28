using CleanCustomers.Aplication.Interfaces;
using CleanCustomers.Domain.Models;


namespace CleanCustomers.Aplication.Service
{
    public class CustomersService : ICustomersService
    {
        private readonly ICustomersRepository _customersRepository;

        public CustomersService(ICustomersRepository customersRepository) 
        {
            _customersRepository = customersRepository;
        }

        public Customers CreateCustomers (Customers customers) 
        {
            return _customersRepository.CreateCustomers(customers);
        }
        
        public List<Customers> GetAllCustomers ()
        {
            return _customersRepository.GetAllCustomers();
        }

        public Customers GetCustomersById(int id) 
        {
            return _customersRepository.GetCustomersById(id);
        }

        public void UpdateCustomers(Customers customers) 
        {
             _customersRepository.UpdateCustomer(customers);
        }

        public void DeleteCustomers(int id)
        {
            _customersRepository.DeleteCustomer(id);
        }

    }
}
