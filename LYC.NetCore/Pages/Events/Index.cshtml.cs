using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LYC.NetCore.Data;
using Lyc.Models;
using Lyc.Models.BusinessModels;
using Microsoft.AspNetCore.Authorization;

namespace LYC.NetCore.Pages.Events
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly LYC.NetCore.Data.ApplicationDbContext _context;

        public IndexModel(LYC.NetCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get;set; }

        public async Task OnGetAsync()
        {
            Event = await _context.Event.Include(e => e.EventLocation).ToListAsync();
        }
    }
}
