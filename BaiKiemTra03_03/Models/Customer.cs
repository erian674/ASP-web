using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra03_03.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Không được để trống!")]
        [Display(Name = "Tên")]
        public string Customer_name { get; set; }
        [Required(ErrorMessage = "Không được để trống!")]
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Không được để trống!")]
        [Display(Name = "Số điện thoại")]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage = "Không được để trống!")]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
