namespace UIPath.Controllers
{
    using System;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using UIPath.Models;
    public class StudentsController : Controller
    {
        private IStudentRepository _studentRepository;
        private ICodeRepository _codeRepository;
        private IUIpathStudentRepository _uipathStudentRepository;
        public StudentsController(IStudentRepository studentRepository, ICodeRepository codeRepository, IUIpathStudentRepository uIpathStudentRepository)
        {
            this._studentRepository = studentRepository;
            this._codeRepository = codeRepository;
            this._uipathStudentRepository = uIpathStudentRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult _Index()
        {
            var students = _studentRepository.Students.Select(x => new
            {
                ID = x.Id,
                Adi = x.FirstName,
                Soyadi = x.LastName,
                Telefon = x.Phone,
                Mail = x.Mail,
                TCKN = x.TCKN

            }).ToList();
            return Json(students);
        }

        public IActionResult List()
        {
            return View();
        }
        [HttpGet]
        public JsonResult _List()
        {
            var students = _uipathStudentRepository.Students.Select(x => new
            {
                ID = x.Id,
                Adi = x.FirstName,
                Soyadi = x.LastName,
                Telefon = x.Phone,
                Mail = x.Mail,
                TCKN = x.TCKN,
                Brans = x.Brans,
                Seans = x.Seans,
                StartDate = x.CourseStartDate,
                EndDate = x.CourseEndDate,
                IsStudent = x.IsStudent
            }).ToList();
            return Json(students);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UIPathStudent student)
        {
            if (ModelState.IsValid)
            {
                if (_studentRepository.Students.Any(x => x.Phone == student.Phone))
                {
                    return View("Error", "Telefon Numarası Daha Önce Kaydedilmiştir!");
                }
                if (_studentRepository.Students.Any(x => x.Mail == student.Mail))
                {
                    return View("Error", "Mail Adresi Daha Önce Kaydedilmiştir!");
                }

                student.FirstName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(student.FirstName);
                student.LastName = student.LastName.ToUpper();
                student.Mail = student.Mail.ToLower();

                _uipathStudentRepository.Add(student);

                return RedirectToAction("Create");
            }
            return View(student);
        }

        [HttpPost]
        public JsonResult _Delete(int id)
        {
            bool result = _studentRepository.Delete(id);
            return Json(result);
        }

        [HttpPost]
        public JsonResult _Remove(int id)
        {
            bool result = _uipathStudentRepository.Delete(id);
            return Json(result);
        }



        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var student = _uipathStudentRepository.GetById(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(UIPathStudent student)
        {
            if (ModelState.IsValid)
            {
                student.FirstName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(student.FirstName);
                student.LastName = student.LastName.ToUpper();
                student.Mail = student.Mail.ToLower();

                _uipathStudentRepository.Update(student);

                return RedirectToAction("List");
            }
            return View(student);
        }
    }
}