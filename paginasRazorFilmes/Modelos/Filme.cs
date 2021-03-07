using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paginasRazorFilmes.Modelos
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataDeLancamento { get; set; }
        public string Genero { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Preco { get; set; }
        public string Classificacao { get; set; }
    }
}
