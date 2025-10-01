using Microsoft.AspNetCore.Mvc;

namespace crudEmpresa.Controllers
{
    [Route("/")]
    [ApiController]
    public class PrincipalController : ControllerBase
    {

        [HttpGet]
        public IActionResult Principal()
        {
            var resultado = new { status = "ok", mensagem = "Api Serviço" };
            return Ok(resultado);
        }

        [HttpGet("/autor")]
        public IActionResult Autor()
        {
            var resultado = new { status = "ok", mensagem = "Nome: Ana Moroni   Telefone: 69992234845   E-mail:993323639karolanakarolini@gmail.com " };
            return Ok(resultado);
        }
    }
}

