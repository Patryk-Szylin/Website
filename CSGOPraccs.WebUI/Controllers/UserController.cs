using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSGOPraccs.Domain.Abstract;
using CSGOPraccs.Domain.Concrete;
using CSGOPraccs.Domain.Entities;

namespace CSGOPraccs.WebUI.Controllers
{
    public class UserController : Controller
    {
        private PraccingContext _context = new PraccingContext();

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();

                return RedirectToAction("List", "Pracc");
            }
            else
            {
                return View(user);
            }            
        }


        public ActionResult Add()
        {
            return View();
        }


    }
}