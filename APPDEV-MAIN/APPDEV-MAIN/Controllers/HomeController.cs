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

        public IActionResult Member3()
        {
            Member3Information member = new Member3Information();

            member.FullName = "Jhon Gabriel I. Barrera";
            member.Course = "BS Computer Science Student";
            member.About = "Hello! I am a Computer Science student who wants to learn more about programming and technology.";
            member.Hobbies = "I enjoy watching anime, listening to music, and playing some games.";
            member.Email = "barrerajhongabriel@gmail.com";

            return View(member);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
