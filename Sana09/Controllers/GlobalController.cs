using Microsoft.AspNetCore.Mvc;
using Sana09.Models;
using System.Diagnostics;

namespace Sana09.Controllers
{
    public class GlobalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Action1()
        {
            return View();
        }
        public IActionResult Action2()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
