using SampleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    public class ViewExController : Controller
    {
        // GET: ViewEx
        public JsonResult Index()
        {
            return Json(new Student { Name="Ram", Address="Pune" },JsonRequestBehavior.AllowGet);
        }

        public ContentResult ContentEx()
        {
            //return Content(@"{'Name':'Ram','Address':'Pune'}","application/json");
            return Content("Test String is being returned in the response");
        }

        public HttpNotFoundResult Http404Ex()
        {
            return HttpNotFound("Some Error Occured");
        }

        public RedirectResult RedirectEx()
        {
            return Redirect("https://www.google.co.in");
        }

        public RedirectToRouteResult RedirectEx2()
        {
            //return RedirectToAction("Index");
            //return RedirectToAction("Welcome","Home");
            return RedirectToRoute("abc");
        }

        public EmptyResult EmptyEx()
        {
            return new EmptyResult();
        }

        //[NonAction]
        //public string TestString()
        //{
        //    return "Some random string";
        //}

        [ActionName("TS")]
        public string TestString()
        {
            return "Some random string";
        }

        public ActionResult VX1()
        {            
            return View();
        }

        public ActionResult VX2()
        {
            return View();
            //return View("LayoutNew");
        }

    }
}