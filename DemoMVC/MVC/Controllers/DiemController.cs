using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class DiemController : Controller
    {
         public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
    public ActionResult Index(DiemModel model)
    {
        if (ModelState.IsValid)
        {
            double TrungBinh = (model.A * 0.6) + (model.B * 0.3) + (model.C * 0.1);
            ViewBag.KetQua = "Điểm tổng kết: " + TrungBinh.ToString("0.00");
        }
        else
        {
            ViewBag.Result = "Vui lòng nhập đầy đủ thông tin!";
        }
        return View(model);
    }
    }

    public class ScoreModel
    {
    }
}