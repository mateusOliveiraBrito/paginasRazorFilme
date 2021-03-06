using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using paginasRazorFilmes.Data;
using paginasRazorFilmes.Modelos;

namespace paginasRazorFilmes.Pages.Filmes
{
    public class CreateModel : PageModel
    {
        private readonly paginasRazorFilmes.Data.paginasRazorFilmesContext _context;

        public CreateModel(paginasRazorFilmes.Data.paginasRazorFilmesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Filme Filme { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Filme.Add(Filme);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
