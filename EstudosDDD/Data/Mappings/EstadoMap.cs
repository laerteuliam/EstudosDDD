﻿using System.Data.Entity.ModelConfiguration;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Data.Mappings
{
    public sealed class EstadoMap
        : EntityTypeConfiguration<EstadoEntity>
    {
        public EstadoMap()
        {
            ToTable("Estado");
            HasKey(x => x.Codigo);
        }
    }
}