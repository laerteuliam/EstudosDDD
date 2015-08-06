using System;
using System.ComponentModel.DataAnnotations;

namespace EstudosDDD.UI.Web.Models.Pessoa
{
    public sealed class IndexModel
    {
        [Key]
        public int Codigo { get; set; }

        public int CodigoLogin { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}