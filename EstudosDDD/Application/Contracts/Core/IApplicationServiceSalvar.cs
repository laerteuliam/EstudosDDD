using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosDDD.Application.Contracts.Core
{
    public interface IApplicationServiceSalvar<TDto,TCodigo>
        where TDto : Dtos.Core.Dto<TCodigo>
    {
        void Salvar(TDto dto);
    }
}
