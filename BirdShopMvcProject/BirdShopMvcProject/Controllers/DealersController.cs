using BirdShopMvcProject.DAL;
using BirdShopMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BirdShopMvcProject.Controllers
{
    public class DealersController : Controller
    {
        BirdShopContext db = new BirdShopContext();
        // GET: Dealers
        public ActionResult Index()
        {
            var dealerList = db.Dealers.ToList();
            return View(dealerList);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Create(Dealers dealer)
        {
            string message = "";
            try
            {
                if (ModelState.IsValid)
                {
                    db.Dealers.Add(dealer);
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