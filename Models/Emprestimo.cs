using System;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }

        [StringLength(100)]
        public string NomeUsuario { get; set; }

        [StringLength(100)]
        public string Telefone { get; set; }
        
        public bool Devolvido { get; set;}

        public int LivroId { get; set; }
        public Livro Livro { get; set; }
    }
}