using Microsoft.AspNetCore.Mvc.Rendering;

using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Models;
using MyWebApp.Services;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Pages
{
    public class PizzaModel : PageModel
    {

       [BindProperty]
        public Pizza NewPizza { get; set; }

        public List<Pizza> pizzas = new();

        
       
        public void OnGet()
        {
            pizzas = PizzaService.GetAll();
            Debug.Write("On Get of Pizza Called");
        }

        public string GlutenFreeText(Pizza pizza)
        {
            if (pizza.IsGlutenFree)
                return "Yes";
            return "No";
        }

        public void Delete() { 
        
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            PizzaService.Add(NewPizza);
            return RedirectToAction("");
        }
    }
}
