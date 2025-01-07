using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class GameController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}