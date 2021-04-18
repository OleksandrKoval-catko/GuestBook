using Microsoft.AspNetCore.Mvc;

namespace GuestBookApi.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class GuestBookController : Controller
    {

        [HttpGet]
        public string GetComments()
        {
            return "Hello";
        }
    }
}