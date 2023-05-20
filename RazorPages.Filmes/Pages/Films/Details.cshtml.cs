using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages.Filmes.Data;
using RazorPages.Filmes.Model;

namespace RazorPages.Filmes.Pages.Films
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPages.Filmes.Data.RazorPagesFilmesContext _context;

        public DetailsModel(RazorPages.Filmes.Data.RazorPagesFilmesContext context)
        {
            _context = context;
        }

      public Film Film { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Film == null)
            {
                return NotFound();
            }

            var film = await _context.Film.FirstOrDefaultAsync(m => m.Id == id);
            if (film == null)
            {
                return NotFound();
            }
            else 
            {
                Film = film;
            }
            return Page();
        }
    }
}
