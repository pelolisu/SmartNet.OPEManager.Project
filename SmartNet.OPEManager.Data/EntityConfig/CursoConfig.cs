using System.Data.Entity.ModelConfiguration;
using SmartNet.OPEManager.Model.Entities;

namespace SmartNet.OPEManager.Data.EntityConfig
{
    public class CursoConfig : EntityTypeConfiguration<Curso>
    {
        public CursoConfig()
        {
            ToTable("Cursos")
                .HasKey(o => o.cursoId);
            Property(o => o.nome)
                .IsRequired()
                .HasMaxLength(255);
            Property(o => o.ativo)
                .IsRequired();
        }
         
    }
}