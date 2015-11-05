using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartNet.OPEManager.Model.Entities;

namespace SmartNet.OPEManager.Data.EntityConfig
{
    public class ProjetoConfig  : EntityTypeConfiguration<Projeto>
    {
        public ProjetoConfig()
        {
            ToTable("Projetos")
            .HasKey(o => new { o.titulo, o.grupoId});

            Property(o => o.empresa)
                .HasMaxLength(200)
                .IsRequired();
            Property(o => o.descricao)
                .HasMaxLength(255)
                .IsRequired();
            Property(o => o.urlSistema)
                .HasMaxLength(500);

            //Foreign Key Many-To-One
            HasRequired(o => o.curso)
                .WithMany()
                .HasForeignKey(o => o.cursoId);

        }
    }
}
