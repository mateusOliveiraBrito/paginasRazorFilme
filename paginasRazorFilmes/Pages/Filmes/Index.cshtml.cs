using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using paginasRazorFilmes.Data;
using paginasRazorFilmes.Modelos;

namespace paginasRazorFilmes.Pages.Filmes
{
    public class IndexModel : PageModel
    {
        private readonly paginasRazorFilmes.Data.paginasRazorFilmesContext _context;

        public IndexModel(paginasRazorFilmes.Data.paginasRazorFilmesContext context)
        {
            _context = context;
        }

        public IList<Filme> Filme { get;set; }

        public async Task OnGetAsync()
        {
            Filme = await _context.Filme.ToListAsync();
        }
    }
}
