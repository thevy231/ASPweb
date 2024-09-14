using BaiKiemTra1.Models;
using Microsoft.AspNetCore.Mvc;

public class TaiKhoanController : Controller
{
    [HttpGet]
    public IActionResult DangKy()
    {
        return View();
    }

    [HttpPost]
    public IActionResult DangKy(TaiKhoanViewModel model)
    {
        if (ModelState.IsValid)
        {          
            return Content($"Tên tài khoản: {model.TenTaiKhoan}, Mật khẩu: {model.MatKhau}, Họ tên: {model.HoTen}, Tuổi: {model.Tuoi}");
        }
        return View(model);
    }
}