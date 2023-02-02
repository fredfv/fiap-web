using Microsoft.AspNetCore.Mvc;

namespace fiap_web.Controllers;

public class HomeController : Controller
{
    public  IActionResult  Index()
    {
        return View();
    }
}