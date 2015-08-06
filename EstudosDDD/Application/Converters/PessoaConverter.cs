using EstudosDDD.Application.Dtos;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Application.Converters
{
    public static class PessoaConverter
    {
        public static PessoaDto ToDto(this PessoaEntity pessoaEntity)
        {
            var pessoaDto = new PessoaDto
            {
                CodigoLogin = pessoaEntity.CodigoLogin,
                DataNascimento = pessoaEntity.DataNascimento,
                Nome = pessoaEntity.Nome,
                SobreNome = pessoaEntity.SobreNome
            };
            return pessoaDto;
        }

        public static PessoaEntity ToEntity(this PessoaDto pessoaDto)
        {
            var pessoaEntity = new PessoaEntity
            {
                CodigoLogin = pessoaDto.CodigoLogin,
                DataNascimento = pessoaDto.DataNascimento,
                Nome = pessoaDto.Nome,
                SobreNome = pessoaDto.SobreNome
            };
            return pessoaEntity;
        }
    }
}