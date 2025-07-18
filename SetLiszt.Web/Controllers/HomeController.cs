using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SetLiszt.Web.Models;

namespace SetLiszt.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) {
        _logger = logger;
    }

    [Route("/", Name = "Home")]
    public IActionResult Index() {
        return View();
    }

    [Route("/privacy", Name = "Privacy")]
    public IActionResult Privacy() {
        return View();
    }

    [Route("/error", Name = "Error")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
