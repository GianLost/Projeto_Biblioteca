using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class Livro
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Titulo { get; set; }
        [StringLength(100)]
        public string Autor { get; set; }
        public int Ano { get; set; }
    }
}