using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages.Shared
{
    public class ProfileModel : PageModel
    {
        
        public string password = "";
        public string email = "";
        public string firstName = "Chandan";
        public string lastName = "";
        public string address = "";
        public void OnGet()
        {
        }
    }
}
