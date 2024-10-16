using BaiKiemTra03_03.Data;
using BaiKiemTra03_03.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BaiKiemTra03_03.Controllers
{
    public class ContractController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ContractController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Contract> Contract = _db.Contract.Include("Contract").ToList();
            return View(Contract);
        }
        //[HttpGet]
        //public IActionResult Upsert(int id)
        //{
        //    Contract Contract = new Contract();
        //    IEnumerable<SelectListItem> dsContract = _db.Contract.Select
        //    (
        //        item => new SelectListItem
        //        {
        //            Value = item.Id.ToString(),
        //            Text = item.Name
        //        }
        //    );
        //    ViewBag.DSContract = dsContract;
        //    if (id == 0)
        //    {
        //        return View(Contract);
        //    }
        //    else
        //    {
        //        Contract = _db.Contract.Include("Contract").FirstOrDefault(sp => sp.Id == id);
        //        return View(Contract);
        //    }
        //}
        //[HttpPost]
        //public IActionResult Upsert(Contract Contract)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (Contract.Id == 0)
        //        {
        //            _db.Contract.Add(Contract);
        //        }
        //        else
        //        {
        //            _db.Contract.Update(Contract);
        //        }
        //        _db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Delete(int id)
        //{
        //    var sanpham = _db.SanPham.FirstOrDefault(sp => sp.Id == id);
        //    if (sanpham == null)
        //    {
        //        return NotFound();
        //    }
        //    _db.SanPham.Remove(sanpham);
        //    _db.SaveChanges();
        //    return Json(new { success = true });
        //}
        //[HttpGet]
        //public IActionResult Search(String searchString)
        //{
        //    if (!string.IsNullOrEmpty(searchString))
        //    {
        //        var sanpham = _db.SanPham.
        //            Where(tl => tl.Name.Contains(searchString)).ToList();
        //        ViewBag.SearchString = searchString;
        //        ViewBag.SanPham = sanpham;
        //    }
        //    else
        //    {
        //        var sanpham = _db.SanPham.ToList();
        //        ViewBag.SanPham = sanpham;
        //    }
        //    return View("Index");
        //}
    }
}
