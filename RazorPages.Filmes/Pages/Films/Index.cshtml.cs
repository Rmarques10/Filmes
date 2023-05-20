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
    public class IndexModel : PageModel
    {
        private readonly RazorPages.Filmes.Data.RazorPagesFilmesContext _context;

        public IndexModel(RazorPages.Filmes.Data.RazorPagesFilmesContext context)
        {
            _context = context;
        }

        public IList<Film> Film { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Film != null)
            {
                Film = await _context.Film.ToListAsync();
            }
        }
    }
}
