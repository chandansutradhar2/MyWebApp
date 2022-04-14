using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Models;
using MyWebApp.Services;
using System.Collections.Generic;
using System.Diagnostics;

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

        public void OnPost() { 
        
        }

        public void OnPostAsync() { 
        
        }

        public string GlutenFreeText(Pizza pizza)
        {
            if (pizza.IsGlutenFree)
                return "Yes";
            return "No";
        }

        public void Delete() { 
        
        }
    }
}
