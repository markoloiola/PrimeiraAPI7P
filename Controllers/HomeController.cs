using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPI7P.Controllers;
[ApiController] //Anotação
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet] //informando que vai ser um requisição do tipo GET
    public string GetMensagem()
    {
        return "Olá Mundo";
    }

    // [HttpGet] //Testado duas requisições de tipos iguais e constado erro
    // public string Getmensagem2()
    // {
    //     return "Olá Mundo 2";
    // }

    [HttpGet("index")]
    public string GetIndex()
    {
        return "Rota Index";
    }

    [HttpPost]
    public object PostObjeto([FromBody] object mensagem)
    {
        return mensagem;
    }

    [HttpPut]
    public object PutObjeto([FromBody] object objeto)
    {
        return objeto;
    }

    [HttpDelete]
    public string delete()
    {
        return "Deletedo com sucesso!";
    }
}
