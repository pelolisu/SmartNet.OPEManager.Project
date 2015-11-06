using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using SmartNet.OPEManager.Domain.Entities;

namespace SmartNet.OPEManager.Data.EntityConfig
{
    public class ProjetoConfig  : EntityTypeConfiguration<Projeto>
    {
        public ProjetoConfig()
        {
            ToTable("Projetos")
            .HasKey(o => o.projetoId);
            Property(o => o.grupoId).HasColumnName("grupoId")
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_GrupoId", 1) { IsUnique = true }));
            Property(o => o.titulo).HasColumnName("titulo")
                         .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_Titulo", 2) { IsUnique = true }));

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
                .WithMany(o => o.projetos)
                .HasForeignKey(o => o.cursoId);

        }
    }
}
