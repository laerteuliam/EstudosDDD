using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using EstudosDDD.Application.Dtos;

namespace UI.Web.Converters.Pessoa
{
    public static class PessoaConverter
    {
        public static Models.Pessoa.IndexModel ToModel(PessoaDto pessoaDto)
        {
            return new Models.Pessoa.IndexModel()
            {
                Codigo = pessoaDto.Codigo,
                CodigoLogin = pessoaDto.CodigoLogin,
                DataNascimento = pessoaDto.DataNascimento,
                Nome = pessoaDto.Nome,
                SobreNome = pessoaDto.SobreNome
            };
        }
    }
}