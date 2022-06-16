using Microsoft.AspNetCore.Mvc;


namespace MobileGroomersAPI.Controllers
{
    [Route("api/Controller")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        [HttpGet("ViewStoreStore")]
        public IActionResult ViewStoreStore([FromQuery] int p_sId)
        {
            return Ok();
        }
    }
}