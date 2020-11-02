using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Packt.Shared;

namespace NorthwindWeb.Pages
{
    public class SuppliersModel : PageModel
    {
        public Northwind db;

        public SuppliersModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        public IEnumerable<string> Suppliers { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web Site - Suppliers";

            Suppliers = db.Suppliers.Select(supplier => supplier.CompanyName);
        }

        // 
        [BindProperty]
        public Supplier Supplier { get; set; }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                db.Suppliers.Add(Supplier);
                db.SaveChanges();
                return  RedirectToPage("/suppliers");
            }
            return Page();
        }
    }
}