
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();
  
        app.UseStaticFiles();
        app.Map("/FormSubmit", HandleFormSubmit);
      	

        app.Run();
        
    }
 
   private static async Task HandleFormSubmit(HttpContext context)
{
   
    if (context.Request.Method == "POST")
    {
        var name = context.Request.Form["bahar"];
        var email = context.Request.Form["1234"];
               context.Response.ContentType = "text/html";
           await context.Response.WriteAsync("<html><body>");
            await context.Response.WriteAsync($"<h1>Name: {name}</h1>");
            await context.Response.WriteAsync($"<h1>Password: {Password}</h1>");
            await context.Response.WriteAsync("</body></html>");
            
    }
}
}



