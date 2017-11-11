using SampleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    //[Route("VX2/{action}")]
    //[RoutePrefix("VX2")]
    //[HandleError]
    public class ViewEx2Controller : Controller
    {
        // GET: ViewEx2
        //http://localhost:8080/ViewEx2/Index
        //[Route("VI2")]
        //[Route("~/VI2")]
        public ActionResult Index()
        {
            throw new Exception();
            return View();
        }

        //[Route("GetStudent/{id=0}")]
        public ActionResult GetStudentDetails(int id = 0)
        {
            return View(ViewExController.students.FirstOrDefault(m => m.Id == id) ?? new StudentData());
            //return View(ViewExController.students.FirstOrDefault(m => m.Id == id));
        }

        // Filters Example
        //Cache -- 2 Types of cache - Server side cache/ client side cache(Browser Cache) 
        [Route("OutputCache")]
        [OutputCache(Duration =60)]
        public ActionResult OutputCacheEx()
        {
            //I need to write some DB Code...
            return View(DateTime.Now);
        }

        [Route("ErrorEx")]
        //[HandleError]
        public ActionResult ErrorEx()
        {
            throw new Exception("Some Error occurred");
            return View();
        }
    }
}