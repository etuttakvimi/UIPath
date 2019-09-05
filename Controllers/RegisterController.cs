using System;
using Microsoft.AspNetCore.Mvc;
using UIPath.Models;

namespace UIPath.Controllers
{
    public class RegisterController : Controller
    {
        private IStudentRepository _studentRepository;
        private ICodeRepository _codeRepository;
        public RegisterController(IStudentRepository studentRepository, ICodeRepository codeRepository)
        {
            this._studentRepository = studentRepository;
            this._codeRepository = codeRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student student)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks");
            }
            return View();
        }


        public IActionResult Random()
        {
            var guid = Guid.NewGuid().ToString().Replace("-", "").ToLower().Remove(6).ToUpper();
            _codeRepository.Add(new Code { LoginCode = guid }); 
            return Content(guid);
        }
    }
}