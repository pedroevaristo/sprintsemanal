using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using mvc.Models;

namespace mvc.Controllers
{
    public class RegisterUserController : Controller
    {
        private readonly IMongoCollection<Register> _users;
        [HttpGet]
        public IActionResult RegisterUser()//Aqui tem como objetivo de repassar as informações de criar o cadastro
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterUser([Bind("Name", "Id")] Register model)// decorator
        {
            if (ModelState.IsValid)
            {
                _users.InsertOne(model);

                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
