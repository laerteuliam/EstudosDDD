using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosDDD.Application.Dtos
{
    public sealed class PessoaDto
    {
        public int CodigoLogin { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Nullable<int> CodigoEndereco { get; set; }
    }
}
