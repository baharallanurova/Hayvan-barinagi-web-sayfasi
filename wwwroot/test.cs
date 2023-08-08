using Microsoft.AspNetCore.Mvc;

[Route("process-form")]
public class FormController : Controller
{
    [HttpPost]
    public IActionResult ProcessForm(string name, string email)
    {    
      Console.WriteLine("test");
        return Ok(); 
    }
}
