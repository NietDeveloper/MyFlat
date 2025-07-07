//================================
// The path that leads to the goal
//================================

using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace MyFlat.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() =>
            Ok("Hello MyFlat");
    }
}
