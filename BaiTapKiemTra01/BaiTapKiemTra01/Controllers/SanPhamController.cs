using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BaiTap2()
        {
            var sanpham = new SanPhamViewModel()
            {
                TenSanPham = "Mỹ phẩm",
                GiaBan = 100000,
                AnhMoTa = "path/to/image.jpg"
            };
            return View(sanpham);
        }
    }
}
