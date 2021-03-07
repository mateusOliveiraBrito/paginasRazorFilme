using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using paginasRazorFilmes.Data;
using paginasRazorFilmes.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace paginasRazorFilmes.Pages.Filmes
{
    public class IndexModel : PageModel
    {
        private readonly paginasRazorFilmesContext _context;

        public IndexModel(paginasRazorFilmesContext context)
        {
            _context = context;
        }

        public IList<Filme> Filme { get; set; }

        [BindProperty(SupportsGet = true)]
        public string StringDePesquisa { get; set; }
        public SelectList Generos { get; set; }

        [BindProperty(SupportsGet = true)]
        public string GeneroFilme { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> queryGenero = from f in _context.Filme
                                             orderby f.Genero
                                             select f.Genero;

            var filmes = from f in _context.Filme
                         select f;

            if (!string.IsNullOrEmpty(StringDePesquisa))
            {
                filmes = filmes.Where(s => s.Titulo.Contains(StringDePesquisa));
            }

            if (!string.IsNullOrEmpty(GeneroFilme))
            {
                filmes = filmes.Where(x => x.Genero == GeneroFilme);
            }

            Generos = new SelectList(await queryGenero.Distinct().ToListAsync());
            Filme = await filmes.ToListAsync();
        }
    }
}
