using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosDDD.Application.Dtos
{
    public sealed class LoginDto
    {
        public int Codigo { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
