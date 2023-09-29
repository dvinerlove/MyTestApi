using Microsoft.AspNetCore.Mvc;

namespace MyTestApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet(Name = "GetName")]
        public string Get(string name = "empty")
        {
            return $"Your name is {name}";
        }
    }
}
