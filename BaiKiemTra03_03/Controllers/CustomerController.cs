using BaiKiemTra03_03.Data;
using BaiKiemTra03_03.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiKiemTra03_03.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CustomerController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var Customer = _db.Customer.ToList();
            ViewBag.Customer = Customer;

            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer Customer)
        {
            if (ModelState.IsValid)
            {
                _db.Customer.Add(Customer);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int CustomerId)
        {
            if (CustomerId == 0)
            {
                return NotFound();
            }
            var Customer = _db.Customer.Find(CustomerId);
            return View(Customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer Customer)
        {
            if (ModelState.IsValid)
            {
                _db.Customer.Update(Customer);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int CustomerId)
        {
            if (CustomerId == 0)
            {
                return NotFound();
            }
            var Customer = _db.Customer.Find(CustomerId);
            return View(Customer);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(int CustomerId)
        {
            var Customer = _db.Customer.Find(CustomerId);
            if (Customer == null)
            {
                return NotFound();
            }
            _db.Customer.Remove(Customer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Detail(int CustomerId)
        {
            if (CustomerId == 0)
            {
                return NotFound();
            }
            var Customer = _db.Customer.Find(CustomerId);
            return View(Customer);
        }
        [HttpGet]
        public IActionResult Search(String searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                var Customer = _db.Customer.
                    Where(tl => tl.Customer_name.Contains(searchString)).ToList();
                ViewBag.SearchString = searchString;
                ViewBag.Customer = Customer;
            }
            else
            {
                var Customer = _db.Customer.ToList();
                ViewBag.Customer = Customer;
            }
            return View("Index");
        }
    }
}
