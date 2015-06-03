using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace Darkages_Web_Client.Controllers
{
    public class HomeController : AsyncController
    {
        public async Task<ActionResult> IndexAsync()
        {
            ViewBag.SyncType = "Asynchronous";
            var index = new Darkages_Web_Client.Models.Index();
            return View("Index", await index.GetTimeNowAsync());
        }

        /*public void IndexAsync()
        {
            
            AsyncManager.OutstandingOperations.Increment();
            AsyncManager.Parameters["timenow"] = DateTime.Now;
            AsyncManager.OutstandingOperations.Decrement();
        }*/

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost,ActionName("GetTicks")]
        public ActionResult GetTicksAction()
        {
            return Json(DateTime.Now.Ticks, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetTicks()
        {
            ViewBag.timenow = DateTime.Now;
            return Json(DateTime.Now.Ticks, JsonRequestBehavior.AllowGet);
        }
    }
}