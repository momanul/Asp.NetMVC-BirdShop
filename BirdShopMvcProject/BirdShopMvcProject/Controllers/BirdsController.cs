using BirdShopMvcProject.DAL;
using BirdShopMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BirdShopMvcProject.Controllers
{
    public class BirdsController : Controller
    {
        BirdShopContext db = new BirdShopContext();
        // GET: Birds
        public ActionResult Index()
        {
            List<Birds> birds = db.Birds.ToList();
            return View(birds);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Create(Birds birds)
        {
            string message = "";
            try
            {
                if (ModelState.IsValid)
                {
                    db.Birds.Add(birds);
                    db.SaveChanges();
                    message = "Data Saved Successfully";
                }
            }
            catch (Exception)
            {

                message = "Error Occured";
            }
            return Json(message, JsonRequestBehavior.AllowGet);
           
        }

    }
}