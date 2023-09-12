using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{

    [HttpGet(Name = "GetUsuario")]
    public string Get()
    {
        return "Nuevo controlador Agregado desde CI/CD";
    }
}
