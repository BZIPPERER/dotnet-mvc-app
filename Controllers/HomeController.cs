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

    
    [HttpPost]
    public IActionResult Login(AccountViewModel asap)
    { 
            
            var username = asap.UserName;
            var experience = asap.ExperienceLevel;

            try
            {
                            
                if (username != null)
                {
                    var SignInResult = true;
             
                    if (SignInResult)
                    {
                        TempData["Message"] = "Logged In";
                        Console.WriteLine(username);
                        Console.WriteLine(experience);
                        return View ( );
                    }
                }
            }
            catch (Exception)
            {
 
                TempData["Message"] = "Nutzer exisiert nicht";
                return RedirectToAction(nameof(Login));
            }
 
            TempData["Message"] = "Login fehlgeschlagen";
            return RedirectToAction(nameof(Login));
    }


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
