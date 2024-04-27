using API.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    // [ApiController]
    [ServiceFilter(typeof(LogUserActivity))]
    [ApiController] //API USERS : A recopier dans base api controllers !
    [Route("api/[controller]")] //API USERS : A recopier dans base api controllers 
    public class BaseApiController :ControllerBase
    {

    }
    
}

