using CodeFirst.DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        private ERPDB dbContext;
        public HomeController()
        {
            dbContext = new ERPDB();
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

        public ActionResult Test()
        {
            var poMaster = new PurchaseMaster
            {
                SupplierCode = "SUP001",
                Date = DateTime.Now
            };
            dbContext.PurchaseMasters.Add(poMaster);
            dbContext.PurchaseDetails.AddRange(new List<PurchaseDetail>
            {
                new PurchaseDetail{ Amount=20, ItemCode="Item001", ItemName="Item 1", PONumber = poMaster.PONumber, Quantity=2, Rate=10  },
                new PurchaseDetail{ Amount=30, ItemCode="Item002", ItemName="Item 2", PONumber = poMaster.PONumber, Quantity=3, Rate=15  },
                new PurchaseDetail{ Amount=80, ItemCode="Item003", ItemName="Item 3", PONumber = poMaster.PONumber, Quantity=4, Rate=20  }
            });

            dbContext.SaveChanges();
            return Content("Test");
        }
    }
}