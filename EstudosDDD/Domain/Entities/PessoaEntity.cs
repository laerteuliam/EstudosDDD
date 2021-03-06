﻿using System;
using EstudosDDD.Domain.Entities.Core;

namespace EstudosDDD.Domain.Entities
{
    public sealed class PessoaEntity : Entity<int>
    {
        public PessoaEntity()
        {
        }

        public PessoaEntity(string nome, string sobrenome, DateTime dataNascimento, LoginEntity loginEntity)
        {
            Login = loginEntity;
            Nome = nome;
            SobreNome = sobrenome;
            CodigoLogin = loginEntity.Codigo;
            DataNascimento = dataNascimento;
        }

        public int CodigoLogin { get; set; }
        public LoginEntity Login { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}