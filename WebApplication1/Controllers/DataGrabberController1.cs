using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataGrabberController1 : ControllerBase
    {
        public JsonResult SomeData()
        {
            return new JsonResult("Some Value");
        }
    }
}
