using ExchangeData.BLL;
using ExchangeData.BLL.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ExchangeDataClient.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAllMessage()
        {
            return View();
        }

        public ActionResult GetALLData([DataSourceRequest] DataSourceRequest request, long caseFileId)
        {
            ViewBag.Message = "Your application description page.";
            var listOfMessage = MassageTextService.GetAll();

            return Json(listOfMessage.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
            //return View(listOfMessage);
        }
        [HttpPost]
        public ActionResult Contact(FormCollection form)
        {
        
            ViewBag.id = form["id"];

            return View(new MessageModel());
        }
        [HttpGet]
        public ActionResult Contact()
        {

            return View();
        }

       
        public ActionResult GetData([DataSourceRequest] DataSourceRequest request, int caseFileId)
        {
            var message = new List<MessageModel>();
             message.Add(MassageTextService.GetBy(caseFileId));
   

            return Json(message.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
            
        }

    }
}