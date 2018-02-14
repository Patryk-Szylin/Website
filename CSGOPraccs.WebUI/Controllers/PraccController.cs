using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSGOPraccs.Domain.Abstract;
using CSGOPraccs.Domain.Entities;

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
            return View(_repository.Praccs);
        }

    }
}