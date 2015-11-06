
using System.Data.Entity.ModelConfiguration;
using SmartNet.OPEManager.Domain.Entities;

namespace SmartNet.OPEManager.Data.EntityConfig
{
    public class TurmaConfig : EntityTypeConfiguration<Turma>
    {
        public TurmaConfig()
        {
            ToTable("Turmas")
                .HasKey(o => o.turmaId);
            Property(o => o.nome)
                .IsRequired()
                .HasMaxLength(255);
            Property(o => o.ativo)
                .IsRequired();
        }
    }
}
