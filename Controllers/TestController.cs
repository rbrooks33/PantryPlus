using Microsoft.AspNetCore.Mvc;

namespace Core3Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        
        [HttpGet][Route("Test")]
        public void Test()
        {
        }
    }
}