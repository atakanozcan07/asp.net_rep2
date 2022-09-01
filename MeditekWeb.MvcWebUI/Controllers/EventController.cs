using MeditekWeb.Business.Abstract;
using MeditekWeb.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeditekWeb.MvcWebUI.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventBs _eventbs;
        public EventController(IEventBs eventBs)
        {
            _eventbs = eventBs;

        }
        public IActionResult Index()
        {
            List<Event> events = _eventbs.GetAll();
            return View(events);
        }
        public IActionResult Details(int id)
        {
            
            return View(_eventbs.GetByEventId(id));
        }
    }
}
