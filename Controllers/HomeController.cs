using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MSS.Models;

namespace MSS.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

}
