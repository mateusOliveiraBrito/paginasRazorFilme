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
    public class DetailsModel : PageModel
    {
        private readonly paginasRazorFilmes.Data.paginasRazorFilmesContext _context;

        public DetailsModel(paginasRazorFilmes.Data.paginasRazorFilmesContext context)
        {
            _context = context;
        }

        public Filme Filme { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Filme = await _context.Filme.FirstOrDefaultAsync(m => m.Id == id);

            if (Filme == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
