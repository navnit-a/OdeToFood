using System.Web.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your app description page.";
            //ViewBag.Location = "Watford, UK";

            var model = new AboutModels
            {
                Name = "nAvz MVC",
                Location = "Watford UK Man"
            };
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
