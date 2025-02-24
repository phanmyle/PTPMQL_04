using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
 public class HoaDonController : Controller
 {
     public IActionResult Index()
    {
        return View();
    }
    
 }
}