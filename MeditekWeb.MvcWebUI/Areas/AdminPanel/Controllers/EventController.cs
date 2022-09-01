using MeditekWeb.Business.Abstract;
using MeditekWeb.Models.Entity;
using MeditekWeb.MvcWebUI.NewFolder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MeditekWeb.MvcWebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
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
        [HttpPost]
        public IActionResult Index(int eventId)
        {

            var entity = _eventbs.GetByEventId(eventId);
            if (entity != null)
            {
                _eventbs.Delete(entity);
            }
            return RedirectToAction("index");

        }
       

        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult New(Event vm)
        {
            _eventbs.Insert(vm);
            return Json(new {isOk=true,message="Etkinlik Başarıyla Kaydedildi"});

        }
        [HttpPost]
        public IActionResult PhotoUpload()
        {
            IFormFileCollection files = Request.Form.Files;
            if (files.Count > 0)
            {
                var fileName = files[0].FileName;
                Console.WriteLine(fileName);
                var contentType = files[0].ContentType;
                if (!contentType.StartsWith("image/"))
                    return Json(new { isOk = false, Message="Lütfen Bir Resim Dosyası Seçiniz"});
                var randomFileName = RandomValueGenerator.GenerateFileName(Path.GetExtension(fileName));
                string uploadPath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/images/eventphotos",randomFileName);
                using (var stream = new FileStream(uploadPath,FileMode.Create))
                {
                    files[0].CopyTo(stream);
                }
                return Json(new { isOk=true, PhotoPath="/images/eventphotos/"+randomFileName});
 



            }
            else
            {
                return Json(new {isOk = false , Message="Lütfen Bir Adet Fotoğraf Seçiniz..."});
            }
            

        }
    }
}
