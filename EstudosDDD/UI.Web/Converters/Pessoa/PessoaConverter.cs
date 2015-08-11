using EstudosDDD.Application.Dtos;
using EstudosDDD.UI.Web.Models.Pessoa;

namespace EstudosDDD.UI.Web.Converters.Pessoa
{
    public static class PessoaConverter
    {
        public static IndexModel ToModel(this PessoaDto pessoaDto)
        {
            return new IndexModel
            {
                Codigo = pessoaDto.Codigo,
                CodigoLogin = pessoaDto.CodigoLogin,
                DataNascimento = pessoaDto.DataNascimento,
                Nome = pessoaDto.Nome,
                SobreNome = pessoaDto.SobreNome
            };
        }

        public static PessoaDto ToDto(this IndexModel pessoaDto)
        {
            return new PessoaDto()
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