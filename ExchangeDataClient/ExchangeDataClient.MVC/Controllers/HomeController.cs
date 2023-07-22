using ExchangeData.BLL;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
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
            return View();
        }

        public ActionResult GetData([DataSourceRequest] DataSourceRequest request)
        {
            ViewBag.Message = "Your application description page.";
            var listOfMessage = MassageTextService.GetAll();

            return Json(listOfMessage.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
            //return View(listOfMessage);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}