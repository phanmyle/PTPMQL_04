using System.ComponentModel.DataAnnotations;

namespace MVC.Models{
    public class BMIModel {
         [Required(ErrorMessage = "Vui lòng nhập cân nặng")]
        public double CanNang { get; set; }
         [Required(ErrorMessage = "Vui lòng nhập chiều cao")]
        public double ChieuCao { get; set; }
        public double bmi { get; set; }
    
    }
}