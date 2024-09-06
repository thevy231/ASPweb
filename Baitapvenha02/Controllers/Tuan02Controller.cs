using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class Tuan02Controller : Controller
    {
       
        public ActionResult Index()
        {
            ViewBag.HoTen = "Nguyễn Thế Vỹ";
            ViewBag.MSSV = "1822040741";
            ViewBag.Nam = 2024;
            return View();
        }

      
        public ActionResult MayTinh(double a, double b, string pheptinh)
        {
            double ketqua = 0;
            string phepTinhDescription = "";

           
            switch (pheptinh)
            {
                case "cong":
                    ketqua = a + b;
                    phepTinhDescription = "Cộng";
                    break;
                case "tru":
                    ketqua = a - b;
                    phepTinhDescription = "Trừ";
                    break;
                case "nhan":
                    ketqua = a * b;
                    phepTinhDescription = "Nhân";
                    break;
                case "chia":
                    if (b != 0)
                    {
                        ketqua = a / b;
                        phepTinhDescription = "Chia";
                    }
                    else
                    {
                        ViewBag.Error = "Không thể chia cho 0.";
                    }
                    break;
                default:
                    ViewBag.Error = "Phép tính không hợp lệ.";
                    break;
            }

        
            ViewBag.KetQua = ketqua;
            ViewBag.PhepTinh = phepTinhDescription;
            ViewBag.A = a;
            ViewBag.B = b;

            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

    }
}
