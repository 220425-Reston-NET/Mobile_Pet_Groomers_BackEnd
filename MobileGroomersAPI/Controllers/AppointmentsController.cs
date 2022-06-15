using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MobileGroomersBL;
using MobileGroomersModels;

namespace MobileGroomersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
         //=================Dependency Injection=============

        private IAppointmentsBL _AppBL;

        public AppointmentsController(IAppointmentsBL AppBL)
        {
            _AppBL = AppBL;
        }

        //=================================================
        [HttpGet("GetAllAppointments")]
        public IActionResult GetAllAppointments()
        {

            try
            {
                List<Appointments> listOfAppointments = _AppBL.GetAllAppointments();
    
                //Followed by "Ok()" it determines what http status code to give
                return Ok(listOfAppointments);
            }
            catch (SqlException)
            {
                return NotFound("No Appointments Exist");
            }
        }

        [HttpPost("AddAppointments")]
        public IActionResult AddAppointments([FromBody] Appointments p_cli)
        {
           try
            {
                _AppBL.AddAppointments(p_cli);
               
                return Created("Appointments was created!", p_cli);
               
            
            }
            catch (SqlException)
            {
                return Conflict();
            }
        }

        [HttpGet("SearchAppointmentsByAppID")]
        public IActionResult SearchAppointments([FromQuery] int appID)
        {
            try
            {
                return Ok(_AppBL.SearchAppointmentsByAppID(appID));
            }
            catch (SqlException)
            {
                return Conflict();
            }
        }
    }
}
