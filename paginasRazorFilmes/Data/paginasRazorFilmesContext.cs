using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<paginasRazorFilmes.Modelos.Filme> Filme { get; set; }
    }
}
