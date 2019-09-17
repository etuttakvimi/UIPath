using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UIPath.Models;
using UIPath.Services;

namespace UIPath.Controllers
{
    public class HomeController : Controller
    {
        private IStudentRepository _studentRepository;
        private ICodeRepository _codeRepository;
        private IGroupRepository _groupRepository;
        private IUIpathStudentRepository _uipathStudentRepository;
        public HomeController(IStudentRepository studentRepository, ICodeRepository codeRepository, IGroupRepository groupRepository, IUIpathStudentRepository uipathStudentRepository)
        {
            this._studentRepository = studentRepository;
            this._codeRepository = codeRepository;
            this._groupRepository = groupRepository;
            this._uipathStudentRepository = uipathStudentRepository;
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
                var code = _groupRepository.Groups.FirstOrDefault(x => x.GroupName == student.Code);
                if (code == null)
                {
                    return View("Error", "Geçeriz Kod!");
                }

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

                _studentRepository.Add(student);



                var uipathStudent = _uipathStudentRepository.Students.FirstOrDefault(x => x.Phone == student.Phone && x.FirstName == student.FirstName && x.LastName == student.LastName);


                if (uipathStudent != null)
                {
                    uipathStudent.TCKN = student.TCKN;
                    _uipathStudentRepository.Update(uipathStudent);
                }
                
                return View("Thanks");
            }
            return View(student);
        }
    }
}