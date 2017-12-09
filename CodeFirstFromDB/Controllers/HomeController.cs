using CodeFirstFromDB.DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstFromDB.Controllers
{
    public class HomeController : Controller
    {
        private ERPSystem dbContext;
        public HomeController()
        {
            dbContext = new ERPSystem();
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

        public ActionResult GetStudents()
        {
            var students = dbContext.StudentMasters.ToList();
            return View(students);
        }

        public ActionResult InsertStudent()
        {
            dbContext.StudentMasters.Add(new StudentMaster
            {
                Address = "Indore",
                Class = "2nd",
                Age = 12,
                MobileNo = 787878778,
                Name = "Hardik"
            });
            dbContext.SaveChanges();

            return Content("");
        }

        public ActionResult EditStudent()
        {
            var stdDetails = dbContext.StudentMasters.FirstOrDefault(m => m.Id == 42);
            stdDetails.Address = "Delhi";
            stdDetails.Age = 7;
            stdDetails.MobileNo = 85858585;
            dbContext.SaveChanges();

            return Content("");
        }

        public ActionResult DeleteStudent()
        {
            var stdDetails = dbContext.StudentMasters.Remove(dbContext.StudentMasters.FirstOrDefault(m => m.Id == 38));
            dbContext.SaveChanges();

            return Content("");
        }

        public ActionResult InsertStudents()
        {
            dbContext.StudentMasters.AddRange(new List<StudentMaster>
            {
                new StudentMaster{ Address="Kolkata", Age=7, Class="1st", MobileNo=8588585, Name="Rihan" },
                new StudentMaster{ Address="Chandigarh", Age=8, Class="2nd", MobileNo=9588585, Name="Hrithik" },
                new StudentMaster{ Address="Chennai", Age=8, Class="2nd", MobileNo=7588585, Name="Prince" }
            });
            dbContext.SaveChanges();
            return Content("");
        }

        public ActionResult CFDBChanges()
        {
            dbContext.CountryMasters.AddRange(new List<CountryMaster>
            {
                new CountryMaster{ Name="India" },
                new CountryMaster{ Name="Pakistan" },
                new CountryMaster{ Name="Srilanka" }
            });
            dbContext.StudentMasters.Add(new StudentMaster { Address="Kolkata", Age=14, Class="7th", MobileNo=858899698, Name="Omkar", RollNo=3  });

            dbContext.SaveChanges();
            return Content("Test");
        }
    }
}