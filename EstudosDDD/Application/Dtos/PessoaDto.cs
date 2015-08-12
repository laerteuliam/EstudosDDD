using System;
using EstudosDDD.Application.Dtos.Core;

namespace EstudosDDD.Application.Dtos
{
    public sealed class PessoaDto : Dto<int>
    {
        public int CodigoLogin { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int? CodigoEndereco { get; set; }
    }
}