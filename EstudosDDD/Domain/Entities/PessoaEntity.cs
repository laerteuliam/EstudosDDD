using System;

namespace EstudosDDD.Domain.Entities
{
    public sealed class PessoaEntity : Core.Entity<int>
    {
        public PessoaEntity(string nome, string sobrenome, LoginEntity login)
        {
            Login = login;
            Nome = nome;
            SobreNome = sobrenome;
        }

        public int CodigoLogin { get; set; }
        public LoginEntity Login { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Nullable<int> CodigoEndereco { get; set; }
        public EnderecoEntity Endereco { get; set; }
    }
}
