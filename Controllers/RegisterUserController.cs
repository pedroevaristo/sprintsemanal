using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class RegisterUserController : Controller
    {
        public IActionResult RegisterUser()//Aqui tem como objetivo de repassar as informações de criar o cadastro
        {
            return View();
        }
       /* public IActionResult ()
        { //fazer a operação de cadastra as informações colcoando abaixo
        }*/
           

    }
}
