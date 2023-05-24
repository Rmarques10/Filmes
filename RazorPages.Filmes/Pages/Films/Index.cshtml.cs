using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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


        [BindProperty(SupportsGet = true)]
        public string Search { get; set; }


        [BindProperty(SupportsGet = true)]
        public string GenderFilm { get; set; }

        public SelectList Genders { get; set; }

        public async Task OnGetAsync()
        {
            var filmes = from m in _context.Film select m;

            if (!string.IsNullOrWhiteSpace(Search))
            {
                filmes = filmes.Where(f => f.Tittle.Contains(Search));
            }
            if (!string.IsNullOrWhiteSpace(GenderFilm))
            {
                filmes = filmes.Where(f => f.Gender == GenderFilm);
            }

            Genders = new SelectList(await _context.Film.Select(o => o.Gender).Distinct().ToListAsync());
            Film = await filmes.ToListAsync();
        }
    }
}
