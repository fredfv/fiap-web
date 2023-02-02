using fiap_web.Models;
using Microsoft.AspNetCore.Mvc;

namespace fiap_web.Controllers;

public class HomeController : Controller
{
    public  IActionResult  Index()
    {
        ViewData["aluno"] = $"F {DateTime.Now}";
        ViewBag.tipo = "F";

        var model = new HomeViewModel(
            "Fulano",
            "Bebidas"
        ); 
        
        return View(model);
    }
}