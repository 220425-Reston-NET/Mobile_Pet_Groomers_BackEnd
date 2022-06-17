using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MobileGoomersModels;
using MobileGroomersBL;


namespace MobileGroomersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
    
        //==============Dependency Injection==============
        private ICustomerBL _customerBL;
        
        public CustomerController(ICustomerBL c_customerBL)
        {
            _customerBL = c_customerBL;
           
        }

        //================================================

        //Data annotation to indicate what type of HTTP verb it is
        //this is an action of a controller
        //It needs what HTTP verb it is associated with
        [HttpGet("GetAllCustomer")]
        public IActionResult GetAllCustomers()
        {
            try
            {
                List<Customer> listOfCurrentCustomers = _customerBL.GetCustomers();
                //Followed by "OK()"
                return Ok(listOfCurrentCustomers);
            }
            catch (SqlException)
            {
                return NotFound("No Customer Exist");
            }

        }

        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer([FromBody] Customer c_customer)
        {
            try
            {
                _customerBL.AddCustomer(c_customer);

                return Created("Customer was created!", c_customer);
            }
            catch (SqlException)
            {
                return Conflict();
            }
        }
    
    }
    
}