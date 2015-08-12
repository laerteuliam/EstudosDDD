using EstudosDDD.Application.Dtos.Core;

namespace EstudosDDD.Application.Dtos
{
    public sealed class LoginDto : Dto<int>
    {
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}