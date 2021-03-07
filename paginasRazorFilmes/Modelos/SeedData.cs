using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using paginasRazorFilmes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paginasRazorFilmes.Modelos
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new paginasRazorFilmesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<paginasRazorFilmesContext>>()))
            {
                if (context.Filme.Any())
                {
                    return;
                }

                context.Filme.AddRange(
                    new Filme
                    {
                        Titulo = "When Harry Met Sally",
                        DataDeLancamento = DateTime.Parse("1989-2-12"),
                        Genero = "Romantic Comedy",
                        Preco = 7.99M,
                        Classificacao = "R"
                    },

                    new Filme
                    {
                        Titulo = "Ghostbusters ",
                        DataDeLancamento = DateTime.Parse("1984-3-13"),
                        Genero = "Comedy",
                        Preco = 8.99M,
                        Classificacao = "R"
                    },

                    new Filme
                    {
                        Titulo = "Ghostbusters 2",
                        DataDeLancamento = DateTime.Parse("1986-2-23"),
                        Genero = "Comedy",
                        Preco = 9.99M,
                        Classificacao = "R"
                    },

                    new Filme
                    {
                        Titulo = "Rio Bravo",
                        DataDeLancamento = DateTime.Parse("1959-4-15"),
                        Genero = "Western",
                        Preco = 3.99M,
                        Classificacao = "R"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
