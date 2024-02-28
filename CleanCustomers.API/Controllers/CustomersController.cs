using CleanCustomers.Aplication.Interfaces;
using CleanCustomers.Domain.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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

        [HttpGet]
        public ActionResult<List<Customers>> Get()
        {
            var moviesFromService = _service.GetAllCustomers();
            return Ok(moviesFromService);
        }
    }
}
