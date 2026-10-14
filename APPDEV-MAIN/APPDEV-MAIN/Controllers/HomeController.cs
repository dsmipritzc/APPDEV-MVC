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

        public IActionResult Member2()
        {
            Member2Information member = new Member2Information();

            member.FirstName = "RC FRITZ";
            member.MiddleInitial = "T";
            member.LastName = "CLEMENTE";
            member.Birthday = "February 29, 2007";
            member.Phone = "+639679116789";
            member.Id = "87000JLBDLVRY";
            member.Address = "Sitio Bayag";

            return View(member);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
