using SampleMVC.DBLayer;
using SampleMVC.Models;
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
        public ActionResult EditStudent(int id = 0)
        {
            var student = dbContext.StudentMasters.SingleOrDefault(m => m.Id == id);
            if (student != null)
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
                var student = dbContext.StudentMasters.SingleOrDefault(m => m.Id == data.Id);
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
            //var rowToBeDeleted = dbContext.StudentMasters.SingleOrDefault(m=>m.Id == id);
            //var student = dbContext.StudentMasters.Remove(rowToBeDeleted);

            var student = dbContext.StudentMasters.Remove(dbContext.StudentMasters.SingleOrDefault(m => m.Id == id));
            dbContext.SaveChanges();

            return RedirectToAction("StudentsList");
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(EmployeeVM data)
        {
            var designation = dbContext.DesignationMasters.FirstOrDefault(a => a.Designation == data.Designation);
            var securityQuestion = dbContext.SecurityQuestionMasters.FirstOrDefault(a => a.Question == data.Question);

            var employee = new EmployeeMaster
            {
                Address = data.Question,
                Answer = data.Answer,
                BankAccountNumber = data.BankAccountNumber,
                BankName = data.BankName,
                BranchName = data.BranchName,
                ContactNumber = data.ContactNumber,
                EmailId = data.EmailId,
                EmpCode = data.EmpCode,
                EmployeeId = data.EmployeeId,
                IFSCCode = data.IFSCCode,
                Name = data.Name,
                Password = data.Password,
                PetName = data.PetName,
                UserName = data.UserName
            };

            if (designation != null)
            {
                employee.DesignationId = designation.DesignationId;
            }
            else
            {
                employee.DesignationMaster = new DesignationMaster
                {
                    Designation = data.Designation
                };
            }
            if (securityQuestion != null)
            {
                employee.SecurityQuestionId = securityQuestion.SecurityQuestionId;
            }
            else
            {
                employee.SecurityQuestionMaster = new SecurityQuestionMaster
                {
                    Question = data.Question
                };
            }
            dbContext.EmployeeMasters.Add(employee);
            dbContext.SaveChanges();

            return View();
        }

        public ActionResult GetBankData()
        {
            var bankData = dbContext.GetBankData(2).FirstOrDefault();
            return Content("Test");
        }
    }
}