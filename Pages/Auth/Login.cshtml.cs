using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
namespace MyWebApp.Pages.Auth
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
        }

        public void DoLogin() {
            Console.WriteLine("Do Login Invoked");
        }

    }
}
