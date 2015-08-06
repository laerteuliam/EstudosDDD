using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UI.Web.Models.Pessoa
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