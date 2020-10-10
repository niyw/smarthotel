using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SmartHotel.Web.Data;
using SmartHotel.Web.Models;

namespace SmartHotel.Web.Pages.Hotels
{
    public class IndexModel : PageModel
    {
        private readonly SmartHotelWebContext _context;

        public IndexModel(SmartHotelWebContext context)
        {
            _context = context;            
        }

        public IList<Hotel> Hotel { get;set; }

        public async Task OnGetAsync()
        {
            Hotel = await _context.Hotels.ToListAsync();
        }
    }
}
