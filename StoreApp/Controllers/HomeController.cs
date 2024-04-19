using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"]="Wellcome";
            return View();
        }
    }
}