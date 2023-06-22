using ApiJwt.Constans;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var ListPaises = PaisConstants.Paises;

            return Ok(ListPaises);
        }
    }
}
