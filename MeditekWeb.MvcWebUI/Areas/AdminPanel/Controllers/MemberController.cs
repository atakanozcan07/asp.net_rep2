using MeditekWeb.Business.Abstract;
using MeditekWeb.Models.Entity;
using MeditekWeb.MvcWebUI.NewFolder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MeditekWeb.MvcWebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class MemberController : Controller
    {
        private readonly IMemberBs _memberbs;
        private readonly ITeamBs _teambs;
        public MemberController(IMemberBs memberBs,ITeamBs teamBs)
        {
            _memberbs = memberBs;
            _teambs = teamBs;

        }
        public IActionResult Index()
        {
            List<Member> members = _memberbs.GetAll();
            return View(members);
        }
        [HttpPost]
        public IActionResult Index(int memberId)
        {

            var entity = _memberbs.GetById(memberId);
            if (entity != null)
            {
                _memberbs.Delete(entity);
            }
            return RedirectToAction("index");

        }
        public IActionResult New()
        {
            List<SelectListItem> teams =_teambs.GetAll().Select(x => new SelectListItem()
            {
                Text = x.TEAM_NAME,
                Value = x.ID.ToString()

            }
            ).ToList();
            teams.Insert(0,new SelectListItem() {Text="Kurul Seçiniz...",Value="-1" });
            
            return View(teams);

        }
        [HttpPost]
        public IActionResult New(Member vm)
        {
            _memberbs.Insert(vm);

            return Json(new { isOk = true, message = "Başarıyla Kaydedildi" });
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
                string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/memberphotos", randomFileName);
                using (var stream = new FileStream(uploadPath, FileMode.Create))
                {
                    files[0].CopyTo(stream);
                }
                return Json(new { isOk = true, PhotoPath = "/images/memberphotos/" + randomFileName });




            }
            else
            {
                return Json(new { isOk = false, Message = "Lütfen Bir Adet Fotoğraf Seçiniz..." });
            }
            
        }
    }
}
