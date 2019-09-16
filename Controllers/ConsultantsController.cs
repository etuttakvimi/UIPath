using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UIPath.Models;
using UIPath.Services;

namespace UIPath.Controllers
{
    public class ConsultantsController : Controller
    {

        private IConsultanRepository _consultantRepository;
        public ConsultantsController(IConsultanRepository consultanRepository)
        {
            this._consultantRepository = consultanRepository;
        }

        public IActionResult Index() { return View(); }
        public IActionResult _Index()
        {

            var consultants = _consultantRepository.Consultants.Select(x => new
            {
                ID = x.Id,
                x.FirstName,
                x.LastName
            });
            return Json(consultants);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Consultant consultant)
        {
            if (ModelState.IsValid)
            {
                consultant.FirstName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(consultant.FirstName);
                consultant.LastName = consultant.LastName.ToUpper();
                _consultantRepository.Add(consultant);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            var consultant = _consultantRepository.GetById(id);
            return View(consultant);
        }

        [HttpPost]
        public IActionResult Edit(Consultant consultant)
        {
            if (ModelState.IsValid)
            {
                consultant.FirstName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(consultant.FirstName);
                consultant.LastName = consultant.LastName.ToUpper();
                _consultantRepository.Update(consultant);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public JsonResult _Remove(int id)
        {
            bool result = _consultantRepository.Delete(id);
            return Json(result);
        }
    }
}