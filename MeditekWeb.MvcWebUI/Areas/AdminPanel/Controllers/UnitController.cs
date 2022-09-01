using MeditekWeb.Business.Abstract;
using MeditekWeb.Models.Entity;
using MeditekWeb.MvcWebUI.NewFolder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MeditekWeb.MvcWebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class UnitController : Controller
    {
        private readonly IUnitBs _unitbs;
        public UnitController(IUnitBs unitBs)
        {
            _unitbs = unitBs;

        }

        public IActionResult Index()
        {
            List<Unit> units =_unitbs.GetAll();

            return View(units);
        }
        [HttpPost]
        public IActionResult Index(int unitId)
        {

            var entity = _unitbs.GetById(unitId);
            if (entity != null)
            {
                _unitbs.Delete(entity);
            }
            return RedirectToAction("index");

        }
        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult New(Unit vm)
        {
            _unitbs.Insert(vm);
            return Json(new { isOk = true });

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
                    return Json(new { isOk = false, Message = "Lütfen Bir Resim Dosyası Seçiniz" });
                var randomFileName = RandomValueGenerator.GenerateFileName(Path.GetExtension(fileName));
                string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/unitphotos", randomFileName);
                using (var stream = new FileStream(uploadPath, FileMode.Create))
                {
                    files[0].CopyTo(stream);
                }
                return Json(new { isOk = true, PhotoPath = "/images/unitphotos/" + randomFileName });




            }
            else
            {
                return Json(new { isOk = false, Message = "Lütfen Bir Adet Fotoğraf Seçiniz..." });
            }
            
        }
    }
}
