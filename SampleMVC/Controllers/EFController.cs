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
        private ERPSystemEntities dbContext;
        public EFController()
        {
            dbContext = new ERPSystemEntities();
        }
        // GET: EF
        [Route("Students")]
        public ActionResult StudentsList()
        {
            var students = dbContext.StudentMasters.ToList(); // Select * from StudentMasters
            return View(students);
        }

        [Route("AddStudent")]
        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }

        [Route("AddStudent")]
        [HttpPost]
        public ActionResult AddStudent(StudentMaster data)
        {
            if (ModelState.IsValid)
            {
                dbContext.StudentMasters.Add(data);
                dbContext.SaveChanges();
                return RedirectToAction("StudentsList");
            }
            return View(data);
        }

        //[Route("EditStudent/{id=0}")]
        [HttpGet]
        public ActionResult EditStudent(int id=0)
        {
            var student = dbContext.StudentMasters.SingleOrDefault(m => m.Id == id);
            if (student!=null)
            {
                //student.IsAdult = 
                return View(student);
            }
            return RedirectToAction("StudentsList");
        }

        //[Route("EditStudent")]
        [HttpPost]
        public ActionResult EditStudent(StudentMaster data)
        {
            if (ModelState.IsValid)
            {
                var student = dbContext.StudentMasters.SingleOrDefault(m=>m.Id==data.Id);
                student.Name = data.Name;
                student.Address = data.Address;
                student.Age = data.Age;
                //student.IsAdult = data.Age >= 18 ? "Y" : "N";
                //student.IsAdult = data.Age >= 18 ? "Y" : "N";
                student.MobileNo = data.MobileNo;
                dbContext.SaveChanges();
                return RedirectToAction("StudentsList");
            }
            return View(data);
        }

        public ActionResult DeleteStudent(int id = 0)
        {
            var student = dbContext.StudentMasters
            
            return RedirectToAction("StudentsList");
        }
        
    }
}