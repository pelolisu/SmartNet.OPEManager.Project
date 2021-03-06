﻿using System.Data.Entity.ModelConfiguration;
using SmartNet.OPEManager.Domain.Entities;

namespace SmartNet.OPEManager.Data.EntityConfig
{
    public class GrupoConfig : EntityTypeConfiguration<Grupo>
    {
        public GrupoConfig()
        {
            ToTable("Grupos")
                .HasKey(o => o.grupoId);
            Property(o => o.nome)
                .IsRequired()
                .HasMaxLength(255);
            Property(o => o.ativo)
                .IsRequired();


        }
    }
}
