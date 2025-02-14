using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class StudentController : Controller
    {
         public IActionResult Index()
    {
        return View();
    }
        [HttpPost]
        public IActionResult Index(string ID,string FullName)
    
    {
        ViewBag.Student= "Xin chao toi la "+FullName+ID;
        return View();
    }

    }
}