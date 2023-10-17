using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Otthonbazar.Data;

namespace Otthonbazar.Pages.Advertisements
{
    public class CreateModel : PageModel
    {
        private readonly Otthonbazar.Data.ApplicationDbContext _context;

        public CreateModel(Otthonbazar.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CityId"] = new SelectList(_context.Cityies, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Advertisement Advertisement { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Advertisements == null || Advertisement == null)
            {
                return Page();
            }

            _context.Advertisements.Add(Advertisement);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        public ActionResult OnGetZip(int zip) => new JsonResult(_context.Cityies.FirstOrDefault(c => c.Zip == zip.ToString()));
    }
   

}
