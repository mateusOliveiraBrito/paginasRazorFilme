using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace paginasRazorFilmes.Modelos
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataDeLancamento { get; set; }
        public string Genero { get; set; }
        public decimal Preco { get; set; }
    }
}
