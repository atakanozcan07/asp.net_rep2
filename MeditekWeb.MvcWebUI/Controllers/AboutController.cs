using MeditekWeb.Business.Abstract;
using MeditekWeb.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeditekWeb.MvcWebUI.Controllers
{
    public class AboutController : Controller
    {
        private readonly IMemberBs _memberBs;
        public AboutController(IMemberBs memberBs)
        {
            _memberBs = memberBs;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Yonetim()
        {
            List<Member> members = _memberBs.GetAll();
            return View(members);
        }
        public IActionResult Icra()
        {
            List<Member> members = _memberBs.GetAll();
            return View(members);
        }
        public IActionResult Denetim()
        {
            List<Member> members = _memberBs.GetAll();
            return View(members);

        }
        public IActionResult Gecmis()
        {
            List<Member> members = _memberBs.GetAll();
            return View(members);

        }

    }
}
