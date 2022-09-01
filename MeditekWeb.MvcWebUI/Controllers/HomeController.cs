using MeditekWeb.Business.Abstract;
using MeditekWeb.Business.Concrete;
using MeditekWeb.DataAccess.Context;
using MeditekWeb.Models.Entity;
using MeditekWeb.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MeditekWeb.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitBs _unitbs;
        private readonly IContactBs _contactbs;


        public HomeController(IUnitBs unitBs, IContactBs contactBs)
        {
            _unitbs = unitBs;
            _contactbs = contactBs;
           

        }


        public IActionResult Index()
        {
            List<Unit> units =_unitbs.GetAll();
            return View(units);
        }
        [HttpPost]
        public IActionResult Index(Contact vm)
        {
            _contactbs.Insert(vm);

            return Json(new { isOk = true, Message = "Mesajınız Başarıyla Kaydedildi" });
        }

    }
}
