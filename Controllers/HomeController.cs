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
        public IActionResult Index(Code code)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index","Register");
            }
            return View();
        }
    }
}