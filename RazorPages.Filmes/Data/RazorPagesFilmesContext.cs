using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPages.Filmes.Model;

namespace RazorPages.Filmes.Data
{
    public class RazorPagesFilmesContext : DbContext
    {
        public RazorPagesFilmesContext (DbContextOptions<RazorPagesFilmesContext> options)
            : base(options)
        {
        }

        public DbSet<Film> Film { get; set; } = default!;
    }
}
