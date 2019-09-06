namespace UIPath.Controllers
{
    using System;
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
    }
}