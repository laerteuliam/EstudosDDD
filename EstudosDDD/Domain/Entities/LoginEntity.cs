using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosDDD.Domain.Entities
{
    public sealed class LoginEntity : Core.Entity<int>
    {
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
