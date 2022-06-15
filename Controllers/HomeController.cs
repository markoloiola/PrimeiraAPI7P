using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPI7P.Controllers;
[ApiController] //Anotação
[Route("[controller]")]
public class HomeController: ControllerBase
{
    [HttpGet] //informando que vai ser um requisição do tipo GET
    public string GetMensagem(){
        return "Olá Mundo";
    }
}
