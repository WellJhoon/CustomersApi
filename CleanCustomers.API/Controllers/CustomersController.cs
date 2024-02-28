using CleanCustomers.Aplication.Interfaces;
using CleanCustomers.Domain.Models;
using Microsoft.AspNetCore.Mvc;


namespace CleanCustomers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersService _service;

        public CustomersController(ICustomersService service)
        {
            _service = service;
        }

        //post
        [HttpPost]
        public ActionResult<Customers> PostProduct(Customers customers)
        {
            var Customer = _service.CreateCustomers(customers);
            return Ok(customers);
        }
        
        //get all
        [HttpGet]
        public ActionResult<List<Customers>> Get()
        {
            var CustomerFromService = _service.GetAllCustomers();
            return Ok(CustomerFromService);
        }


        //Get By Id:
        [HttpGet("{id}")]
        public ActionResult<Customers> GetById(int id)
        {
            var customers = _service.GetCustomersById(id);
            if (customers == null)
            {
                return NotFound();
            }
            return Ok(customers);
        }

        //Update
        [HttpPut("{id}")]
        public IActionResult Put(int id, Customers customers)
        {
            if (id != customers.Id)
            {
                return BadRequest();
            }

            try
            {
                _service.UpdateCustomers(customers);
            }
            catch (Exception)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingCustomers = _service.GetCustomersById(id);
            if (existingCustomers == null)
            {
                return NotFound();
            }

            _service.DeleteCustomers(id);
            return NoContent();
        }

    }
}
