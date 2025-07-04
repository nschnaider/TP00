using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP00.Models;

namespace TP00.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
