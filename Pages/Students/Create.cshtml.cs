using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using crud_aspnet_core_mvc_balta.Data;
using crud_aspnet_core_mvc_balta.Models;

namespace crud_aspnet_core_mvc_balta.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly crud_aspnet_core_mvc_balta.Data.ApplicationDbContext _context;

        public CreateModel(crud_aspnet_core_mvc_balta.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Students.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
