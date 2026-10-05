using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalController : ControllerBase
    {
        [HttpGet(Name = "count")]
        public async Task<int> CountFiles()
        {
            return await Task.FromResult(3);
        }
    }
}
