using ExchangeData.BLL;
using System.Web.Mvc;

namespace ExchangeDataClient.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var x = MassageTextService.GetBy(1);


            return View(x);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}