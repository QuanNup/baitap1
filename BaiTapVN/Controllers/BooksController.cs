using Microsoft.AspNetCore.Mvc;

namespace BaiTapVN.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Book1()
        {
            return View();
        }
    }
}
