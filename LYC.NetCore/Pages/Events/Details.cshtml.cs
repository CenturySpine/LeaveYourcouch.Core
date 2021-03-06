﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LYC.NetCore.Data;
using Lyc.Models;
using Lyc.Models.BusinessModels;

namespace LYC.NetCore.Pages.Events
{
    public class DetailsModel : PageModel
    {
        private readonly LYC.NetCore.Data.ApplicationDbContext _context;

        public DetailsModel(LYC.NetCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.FirstOrDefaultAsync(m => m.Id == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
