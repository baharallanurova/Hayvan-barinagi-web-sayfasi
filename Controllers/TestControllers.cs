
using Microsoft.AspNetCore.Mvc;

   namespace MyApp.Controllers
   {
       [Route("Test")]
       public class TestController : Controller
       {
           [Route("Index")]
           public IActionResult Login()
           {
             
               return View();
           }
       }
   }
   