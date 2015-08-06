using System;

namespace EstudosDDD.Domain.Entities.Core
{
    public abstract class Entity<TCodigo>
    {
        public Entity()
        {
            DataCadastro = DateTime.Now;
        }

        public TCodigo Codigo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}