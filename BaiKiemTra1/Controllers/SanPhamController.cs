using BaiKiemTra1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiKiemTra1.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BaiTap2()
        {
            var sanPham = new SanPhamViewModel
            {
                TenSanPham = "Penhouse",
                GiaBan = 3000000000,
                AnhMoTa = "penhouse.jpg"
            };

            return View(sanPham);
        }
    }
    
}
