using Microsoft.AspNetCore.Mvc;

namespace Source.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
