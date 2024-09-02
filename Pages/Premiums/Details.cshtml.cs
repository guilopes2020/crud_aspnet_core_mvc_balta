using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using crud_aspnet_core_mvc_balta.Data;
using crud_aspnet_core_mvc_balta.Models;

namespace crud_aspnet_core_mvc_balta.Pages.Premiums
{
    public class DetailsModel : PageModel
    {
        private readonly crud_aspnet_core_mvc_balta.Data.ApplicationDbContext _context;

        public DetailsModel(crud_aspnet_core_mvc_balta.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Premium Premium { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var premium = await _context.Premiums.FirstOrDefaultAsync(m => m.Id == id);
            if (premium == null)
            {
                return NotFound();
            }
            else
            {
                Premium = premium;
            }
            return Page();
        }
    }
}
