using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class BMIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult IActionResult (BMIModel model)
    {
        if (ModelState.IsValid)
        {
            // Tính toán BMI
            double heightInMeters = model.ChieuCao / 100;
            double bmi = model.CanNang / (heightInMeters * heightInMeters);
            string status;
            if (bmi < 18.5) status = "Gầy";
            else if (bmi < 23) status = "Bình thường";
            else if (bmi < 25) status = "Tiền béo phì";
            else status = "Béo phì";

            // Gửi kết quả về View
            ViewBag.BMI = Math.Round(bmi, 1);
            ViewBag.Status = status;
        }
        
        return View(model);
    }
            
    }
}
