using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDHW.Data;

namespace CRUDHW.Pages.myManufacture
{
    public class IndexModel : PageModel
    {
        private readonly CRUDHW.Data.ApplicationDbContext _context;

        public IndexModel(CRUDHW.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Manufacturers> Manufacturers { get;set; }

        public async Task OnGetAsync()
        {
            Manufacturers = await _context.Manufacturers
                .Include(m => m.Car).ToListAsync();
        }
    }
}
