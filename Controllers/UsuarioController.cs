using Microsoft.AspNetCore.Mvc;

namespace OpenLIMS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "EMERSON PASSOU AQUI";
        }

        // [HttpPost]

    }
}