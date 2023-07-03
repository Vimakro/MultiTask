using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("saludos")]
    [ApiController]
    public class SaludosController:ControllerBase
    {
        [HttpGet("{nombre}")]
        public ActionResult<string> ObtenerSaludo(string nombre) {
            return $"Hola , {nombre}!";
        }
    }
}
