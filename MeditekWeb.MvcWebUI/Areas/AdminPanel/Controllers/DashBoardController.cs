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
    public class DashBoardController : Controller
    {
        private readonly IUnitBs _unitBs;
        private readonly IEventBs _eventBs;
        public DashBoardController(IUnitBs unitBs,IEventBs eventBs)
        {
            _unitBs = unitBs;
            _eventBs = eventBs;

        }
       
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
