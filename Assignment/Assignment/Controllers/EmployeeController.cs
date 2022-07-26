using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
