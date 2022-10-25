using Microsoft.AspNetCore.Mvc;

namespace TruyenDuLieu.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.TenMon = "Công nghệ NET";
            ViewBag.NoMon = "Cong nghe net";
            ViewData["TenMđion"] = ".NET Technology";
            return View();
        }
    }
}
