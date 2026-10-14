using APPDEV_MAIN.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace APPDEV_MAIN.Controllers
{
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

        public IActionResult Member1()
        {
            Member1 member = new Member1();

            member.ID = "1218";
            member.FirstName = "John Kylle";
            member.LastName = "Colcol";
            member.Specialty = "Automation, AI, and ML";


            
            return View(member);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
