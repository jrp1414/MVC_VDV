using SampleMVC.DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    public class EFController : Controller
    {
        // GET: EF
        [Route("Students")]
        public ActionResult StudentsList()
        {
            var dbContext = new ERPSystemEntities();
            var students = dbContext.StudentMasters.ToList(); // Select * from StudentMasters
            return View(students);
        }
    }
}