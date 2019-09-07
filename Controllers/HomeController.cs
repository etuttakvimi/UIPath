using Microsoft.AspNetCore.Mvc;
using UIPath.Models;

namespace UIPath.Controllers
{
    public class HomeController : Controller
    {
        private IStudentRepository _studentRepository;
        private ICodeRepository _codeRepository;
        public HomeController(IStudentRepository studentRepository, ICodeRepository codeRepository)
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
                var code = _codeRepository.GetCode(student.Code);
                if (code == null)
                {
                    return View("Error");
                }
                student.FirstName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(student.FirstName);
                student.LastName = student.LastName.ToUpper();
                student.Mail = student.Mail.ToLower();

                _studentRepository.Add(student);
                return View("Thanks");
            }
            return View(student);
        }
    }
}