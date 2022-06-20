using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MobileGroomersBL;
using MobileGroomersModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public IActionResult AddAppointments([FromBody] Appointments p_app)
        {
           try
            {
                _AppBL.AddAppointments(p_app);
               
                return Created("Appointments was created!", p_app);
               
            
            }
            catch (SqlException)
            {
                return Conflict();
            }
        }

        [HttpGet("SearchAppointmentsByCustName")]
        public IActionResult SearchAppointments([FromQuery] string CustName)
        {
            try
            {
                return Ok(_AppBL.SearchAppointmentsByCustName(CustName));
            }
            catch (SqlException)
            {
                return Conflict();
            }
        }
    }
}