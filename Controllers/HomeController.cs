using CancellationTokenApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CancellationTokenApp.Controllers;

public class HomeController : Controller
{

    public HomeController()
    {
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Start(CancellationToken cancellationToken)
    {
        try
        {
            await ProccessingService.Start(cancellationToken);
            Console.WriteLine("Processamento concluído com sucesso ✅");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Processamento cancelado pelo usuário ❌");
        }

        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> StartNoCancellation()
    {
        try
        {
            await ProccessingService.StartNoCancellation();
            Console.WriteLine("Processamento concluído com sucesso ✅");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Processamento cancelado pelo usuário ❌");
        }

        return Ok();
    }
}
