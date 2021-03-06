﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosDDD.Application.Contracts.Core
{
    public interface IApplicationServiceListar<TDto,TCodigo>
        where TDto : Dtos.Core.Dto<TCodigo>
    {
        IEnumerable<TDto> Listar();
    }
}
