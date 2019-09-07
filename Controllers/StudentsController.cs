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
        public StudentsController(IStudentRepository studentRepository, ICodeRepository codeRepository)
        {
            this._studentRepository = studentRepository;
            this._codeRepository = codeRepository;
        }
        public IActionResult Index()
        {
            var student = _studentRepository.Students;

            return View(student);
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
                Mail = x.Mail 
            }).ToList();
            return Json(students); 
        }

        [HttpPost]
        public JsonResult _Delete(int id)
        {

            bool result = _studentRepository.Delete(id);
            return Json(result);
        }
    }
}