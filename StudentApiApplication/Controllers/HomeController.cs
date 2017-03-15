using System.Web.Mvc;

namespace StudentApiApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Data()
        {
            ViewBag.Title = "Student Details";
            return View();
        }
    }
}
