using System;

namespace SistemaSeguradosPOC.Models
{
    public class Segurado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal ValorContribuicao { get; set; }
    }
}
