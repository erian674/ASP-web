using BaiKiemTra03_03.Data;
using BaiKiemTra03_03.Models;
using Microsoft.AspNetCore.Mvc;

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
            var contract = _db.Contract.ToList();
            ViewBag.Contract = contract;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Contract ct)
        {
            if (ModelState.IsValid)
            {
                _db.Contract.Add(ct);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var ct = _db.Contract.Find(id);
            return View(ct);
        }

        [HttpPost]
        public IActionResult Edit(Contract ct)
        {
            if (ModelState.IsValid)
            {
                _db.Contract.Update(ct);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    if (id == 0)
        //    {
        //        return NotFound();
        //    }
        //    var theloai = _db.TheLoai.Find(id);
        //    return View(theloai);
        //}
        //[HttpPost]
        //public IActionResult DeleteConfirm(int id)
        //{
        //    var theloai = _db.TheLoai.Find(id);
        //    if (theloai == null)
        //    {
        //        return NotFound();
        //    }
        //    _db.TheLoai.Remove(theloai);
        //    _db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        //[HttpGet]
        //public IActionResult Detail(int id)
        //{
        //    if (id == 0)
        //    {
        //        return NotFound();
        //    }
        //    var theloai = _db.TheLoai.Find(id);
        //    return View(theloai);
        //}
        //[HttpGet]
        //public IActionResult Search(String searchString)
        //{
        //    if (!string.IsNullOrEmpty(searchString))
        //    {
        //        var theloai = _db.TheLoai.
        //            Where(tl => tl.Name.Contains(searchString)).ToList();
        //        ViewBag.SearchString = searchString;
        //        ViewBag.TheLoai = theloai;
        //    }
        //    else
        //    {
        //        var theloai = _db.TheLoai.ToList();
        //        ViewBag.TheLoai = theloai;
        //    }
        //    return View("Index");
        //}
    }
}
