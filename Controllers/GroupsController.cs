using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UIPath.Models;
using UIPath.Services;

namespace UIPath.Controllers
{
    public class GroupsController : Controller
    {

        private IGroupRepository _groupRepository;
        private IConsultanRepository _consultantRepository;
        public GroupsController(IGroupRepository groupRepository, IConsultanRepository consultanRepository)
        {
            this._groupRepository = groupRepository;
            this._consultantRepository = consultanRepository;
        }



        public IActionResult Index()
        {
            return View();
        }

        public JsonResult _Index()
        {
            var groups = _groupRepository.Groups.Select(x => new
            {
                ID = x.Id,
                x.GroupName,
                StudentsCount = x.Students.Count,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                Status = x.Statu,
                Consultant = x.Consultant.FullName
            });
            return Json(groups);
        }
        public IActionResult Create()
        {
            ViewBag.ConsultantId = new SelectList(_consultantRepository.Consultants, "Id", "FullName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Group group)
        {
            if (ModelState.IsValid)
            {
                group.GroupName = group.GroupName.ToUpper();

                _groupRepository.Add(group);
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Edit(int? id)
        {
            ViewBag.ConsultantId = new SelectList(_consultantRepository.Consultants, "Id", "FullName");
            var group = _groupRepository.GetById(id);
            return View(group);
        }
        [HttpPost]
        public IActionResult Edit(Group group)
        {
            if (ModelState.IsValid)
            {
                _groupRepository.Update(group);
                return RedirectToAction("Index");
            }
            ViewBag.ConsultantId = new SelectList(_consultantRepository.Consultants, "Id", "FullName");
            return View();
        }



        [HttpPost]
        public JsonResult _Remove(int id)
        {
            var group = _groupRepository.GetById(id);
            if (group.GroupName == "UIPATH")
            {

                return Json("Group Silinemez!");
            }
            bool result = _groupRepository.Delete(id);
            return Json(result);
        }

    }
}