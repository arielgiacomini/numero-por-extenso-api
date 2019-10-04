using Microsoft.AspNetCore.Mvc;
using numero_por_extenso_api.Application;

namespace numero_por_extenso_api.Controllers
{
    [ApiController]
    [Route("numero-por-extenso")]
    [Produces("application/json")]
    public class NumeroExtensoController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetNumeroPorExtenso(string numero)
        {
            NumeroPorExtenso numeroExtenso = new NumeroPorExtenso();
            var final = numeroExtenso.GetNumeroPorExtenso(numero);

            return Ok(final);
        }
    }
}