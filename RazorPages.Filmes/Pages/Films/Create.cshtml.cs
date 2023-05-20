using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPages.Filmes.Data;
using RazorPages.Filmes.Model;

namespace RazorPages.Filmes.Pages.Films
{
    public class CreateModel : PageModel
    {
        private readonly RazorPages.Filmes.Data.RazorPagesFilmesContext _context;

        public CreateModel(RazorPages.Filmes.Data.RazorPagesFilmesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Film Film { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Film == null || Film == null)
            {
                return Page();
            }

            _context.Film.Add(Film);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
