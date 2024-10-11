using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    public class RegisterUserController : Controller
    {
        public IActionResult RegisterUser()
        {
            return View();
        }
    }
}
