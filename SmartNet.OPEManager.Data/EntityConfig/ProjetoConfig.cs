using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using SmartNet.OPEManager.Domain.Entities;

namespace SmartNet.OPEManager.Data.EntityConfig
{
    public class ProjetoConfig : EntityTypeConfiguration<Projeto>
    {
        public ProjetoConfig()
        {
            ToTable("Projetos")
            .HasKey(o => o.projetoId);
            Property(o => o.empresa)
                 .HasMaxLength(200)
                 .IsRequired();
            Property(o => o.descricao)
                .HasMaxLength(255)
                .IsRequired();
            Property(o => o.urlSistema)
                .HasMaxLength(500);

            //1:N - 1 projeto DEVE ter 1 curso e 1 curso pode ter muitos projetos
            HasRequired(o => o.curso)
                .WithMany(o => o.projetos)
                .HasForeignKey(o => o.cursoId);

        }
    }
}
