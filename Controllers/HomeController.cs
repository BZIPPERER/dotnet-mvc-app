using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using gameapplication.Models;

namespace gameapplication.Controllers;

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

    [HttpGet]
    public ViewResult Form()
    { 
        return View();
    }

    // Execute on Form posting 
    [HttpPost]
    public ViewResult formal([FromForm] string location, [FromForm] string email)
    { 
        //simple data assignment to ViewBag 
        int mMonth =  DateTime.Now.Month;
        int mDays  = DateTime.Now.Day;
        int mYear  = DateTime.Now.Year;
        
        ViewBag.MesAgora = mMonth;
        ViewBag.MesCulpa = mDays;
        ViewBag.MesCherri = mYear;

        ViewBag.Str1 = location;
        ViewBag.Str2 = email;
        return View();
    }
// Nach Art von https://makolyte.com/aspdotnet-core-get-posted-form-data-in-an-api-controller/

    public IActionResult Privacy()
    {
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
