﻿namespace EstudosDDD.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryUpdate<TEntity, TCodigo>
        where TEntity : Entities.Core.Entity<TCodigo>
    {
        void Update(TEntity t);
    }
}