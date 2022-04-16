using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using MyWebApp.Models;
namespace MyWebApp.Pages.Auth

{
    public class LoginModel : PageModel
    {
        public string email;
        public string password;
        public PizzaSize size;
        public void OnGet()
        {
        }

        public void DoLogin() {
            Console.WriteLine("Do Login Invoked");
            //TODO establish connection with database and send data
            bool result=false; //result value will be determined by db operation

            if (result == true)
            {
                //todo : 
            }
            else { 
             //create user session--send request to db to fetch user profile
             //map returned data into object
             Models.User user = new Models.User();
               
             //load profile in singleton object
            //redirect to home
            }
        }

    }
}
