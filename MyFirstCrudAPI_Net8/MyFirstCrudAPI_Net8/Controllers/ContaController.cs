using Microsoft.AspNetCore.Mvc;

namespace MyFirstCrudAPI_Net8.Controllers;

public class ContaController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}