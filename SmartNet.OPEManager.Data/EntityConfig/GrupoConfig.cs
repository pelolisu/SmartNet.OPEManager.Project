using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartNet.OPEManager.Model.Entities;

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
