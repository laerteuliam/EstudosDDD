using System;

namespace EstudosDDD.Application.Dtos
{
    public sealed class PessoaDto
    {
        public int Codigo { get; set; }
        public int CodigoLogin { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int? CodigoEndereco { get; set; }
    }
}