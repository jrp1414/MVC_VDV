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
            return Json(new Student { Name = "Ram", Address = "Pune" }, JsonRequestBehavior.AllowGet);
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

        public ActionResult PartialViewEx()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult ChildPage2()
        {
            return PartialView();
        }

        //public ActionResult ModelEx1()
        //{
        //    //I will write few lines of code which will execute some query in the DB and get me the data of this student.
        //    //var std = new StudentData { Id = 1, Name = "Ram", Address = "Pune", Age = 25 };
        //    //return View();
        //    //return View(std);
        //}

        //public ActionResult ModelEx1(int id,)
        //{
        //    return View(students.FirstOrDefault(a=>a.Id== id));
        //}

        public ActionResult ModelEx1(int id, string name)
        {
            return View(students.FirstOrDefault(a => a.Id == id));
        }

        public ActionResult ModelEx2()
        {
            //I will write few lines of code which will execute some query in the DB and get me the data of this student.

            return View(students);
        }

        [HttpGet]
        public ActionResult CreateStudentHtml()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateStudentHtml(FormCollection form, StudentData data)
        {
            //var name = form["Name"];
            //var address = form["Address"];
            //var age = Convert.ToInt32(form["Age"]);
            var id = students.Max(m => m.Id);
            //students.Add(new StudentData { Id= (id+1), Name=name, Address=address, Age= age });
            students.Add(new StudentData { Id= (id+1), Name=data.Name, Address=data.Address, Age= data.Age});

            //return View();
            return RedirectToAction("ModelEx2");
        }


        static List<StudentData> students = new List<StudentData>
            {
                new StudentData{ Id=1, Name="Ram", Address="Pune", Age=20 },
                new StudentData{ Id=2, Name="Ramesh", Address="Mumbai", Age=19 },
                new StudentData{ Id=3, Name="Rohan", Address="Chennai", Age=20 },
                new StudentData{ Id=4, Name="Raj", Address="Delhi", Age=19 },
                new StudentData{ Id=5, Name="Rajesh", Address="Mumbai", Age=18 }
            };

    }
}