using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers;

public class Exercise : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}