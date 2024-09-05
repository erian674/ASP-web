using Microsoft.AspNetCore.Mvc;

namespace BaiTapVeNha_20.Controllers
{
    public class Tuan02Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Hoten = "Lê Thị Quỳnh Như";
            ViewBag.MSSV = "1822041437";
            ViewData["Nam"] = "2004";
            return View();
        }
    }
}
