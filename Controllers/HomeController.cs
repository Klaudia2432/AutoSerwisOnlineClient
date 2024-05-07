using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AutoSerwisOnline.Models;

namespace AutoSerwisOnline.Controllers;

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

    public IActionResult BookService()
    {
        return View();
    }
    
    public IActionResult ContactPage()
    {
        return View();
    }
    
    public IActionResult ReservationStatus()
    {
        return View();
    }

    public IActionResult Help()
    {
        return View();
    }
    
    public IActionResult TermsAndConditions()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
}