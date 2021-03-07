using Microsoft.EntityFrameworkCore;
using paginasRazorFilmes.Modelos;

namespace paginasRazorFilmes.Data
{
    public class paginasRazorFilmesContext : DbContext
    {
        public paginasRazorFilmesContext (DbContextOptions<paginasRazorFilmesContext> options)
            : base(options)
        {
        }

        public DbSet<Filme> Filme { get; set; }
    }
}
