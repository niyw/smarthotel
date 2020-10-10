using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartHotel.Web.Data;
using SmartHotel.Web.Models;

namespace SmartHotel.Web.Pages.Hotels
{
    public class CreateModel : PageModel
    {
        private readonly SmartHotel.Web.Data.SmartHotelWebContext _context;

        public CreateModel(SmartHotel.Web.Data.SmartHotelWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Hotel Hotel { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Hotels.Add(Hotel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
