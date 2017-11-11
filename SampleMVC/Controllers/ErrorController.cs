using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        [Route("Error404")]
        public ActionResult Error404()
        {
            return View();
        }

        [Route("Error500")]
        public ActionResult Error500()
        {
            return View();
        }
    }
}