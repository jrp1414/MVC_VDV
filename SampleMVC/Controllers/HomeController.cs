using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    //HomeController cnt = new HomeController();
    //cnt.Index();
    //Reflection -- By using Reflection, we can dynamically create the object of any Class just by finding the 
    //name of that class and invoke any method of that class using relfection also
    // MVCHandler uses ControllerFactory Class to create the controller instance
    //ControllerFactory class takes care of the instance creation of the MVC Controller class and invokes the action method
    //localhost:858/Home/Index
    //Response.Write()

    //Razor View Engine
    //ASPX View Engine
    public class HomeController : Controller
    {
        public string HelloWorld()
        {
            return "Hello World";
        }

        //localhost:8585/Home/Welcome
        //public ViewResult Welcome()
        public ActionResult Welcome()
        {
            //if (5>10)
            //{
            //    return View();
            //}
            //else if(10>20)
            //{
            //    return View("Welcome");
            //}
            //return View();
            //return View("Welcome2");            
            return View("~/Views/ViewEx/Test.cshtml");
        }

        public ActionResult Index()
        {
            return View();
        }

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
    }
}