using System;

namespace EstudosDDD.Domain.Entities
{
    public sealed class PessoaEntity : Core.Entity<int>
    {
        public LoginEntity Login { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public EnderecoEntity Endereco { get; set; }
    }
}
