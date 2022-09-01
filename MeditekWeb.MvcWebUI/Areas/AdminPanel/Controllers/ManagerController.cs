using MeditekWeb.Business.Abstract;
using MeditekWeb.Models.Entity;
using MeditekWeb.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeditekWeb.MvcWebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ManagerController : Controller
    {
        private readonly IManagerBs _managerbs;
        public ManagerController(IManagerBs managerBs)
        {
            _managerbs = managerBs;

        }

        [HttpGet]
        public IActionResult Login()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Login(ManagerLoginVm vm)
        {
            Manager manager =_managerbs.LogIn(vm.UserName, vm.Password);
            if (manager != null)
                return Json(new { isOk = true });

            return Json(new { isOk=false , Message="Kullanıcı Bulunamadı" });
        }
    }
}
