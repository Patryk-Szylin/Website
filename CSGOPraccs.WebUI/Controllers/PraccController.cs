using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSGOPraccs.Domain.Abstract;
using CSGOPraccs.Domain.Entities;
using CSGOPraccs.WebUI.Models;

namespace CSGOPraccs.WebUI.Controllers
{
    public class PraccController : Controller
    {
        private IPraccRepository _repository;

        public PraccController(IPraccRepository praccRepository)
        {
            this._repository = praccRepository;
        }

        public ViewResult List()
        {
            PraccListViewModel model = new PraccListViewModel
            {
                Praccs = _repository.Praccs
            };

            return View(model);
        }

        [HttpPost]
        public ViewResult Add(Pracc practiceGame)
        {
            return View(practiceGame);
        }

        public ViewResult Add()
        {
            return View();
        }





    }
}