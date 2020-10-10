﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly SmartHotel.Web.Data.SmartHotelWebContext _context;

        public DetailsModel(SmartHotel.Web.Data.SmartHotelWebContext context)
        {
            _context = context;
        }

        public Hotel Hotel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hotel = await _context.Hotels.FirstOrDefaultAsync(m => m.Id == id);

            if (Hotel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
