using Microsoft.AspNetCore.Mvc;

namespace MyFirstCrudAPI_Net8.Controllers;

[Route("api/[controller]")]
[ApiController]
// [Authorize] // Exige autenticação JWT 
public class ContaController : Controller
{
     private readonly ContaSer _depositoService;

        public ContaController(DepositoService depositoService)
        {
            _depositoService = depositoService;
        }

    public IActionResult Index()
    {
        return View();
    }
}