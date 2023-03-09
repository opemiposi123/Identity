using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
    public class DashBoardController : Controller
    {
        [Authorize]
        public IActionResult Display()
        {
            return View();
        }
    }
}
