using MeditekWeb.Business.Abstract;
using MeditekWeb.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeditekWeb.MvcWebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ContactController : Controller
    {
        private readonly IContactBs _contactbs;
        public ContactController(IContactBs contactBs)
        {
            _contactbs = contactBs;

        }
        public IActionResult Index()
        {
            List<Contact> contacts = _contactbs.GetAll();
            return View(contacts);
        }
    }
}
