using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AlexaController : ControllerBase
{
    [HttpGet]
    public OkObjectResult Teste()
    {
        return Ok("Retorno ok");
    }
}