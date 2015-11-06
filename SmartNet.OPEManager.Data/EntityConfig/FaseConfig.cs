using System.Data.Entity.ModelConfiguration;
using SmartNet.OPEManager.Domain.Entities;

namespace SmartNet.OPEManager.Data.EntityConfig
{
    public class FaseConfig : EntityTypeConfiguration<Fase>
    {
        public FaseConfig()
        {
            ToTable("Fases")
             .HasKey(o => o.faseId);
            HasRequired(o => o.projeto)
                .WithMany(o => o.fases)
                .HasForeignKey(o => o.projetoId);
            HasRequired(o => o.semestre)
               .WithMany()
               .HasForeignKey(o => o.semestreId);
            HasRequired(o => o.turma)
            .WithMany()
            .HasForeignKey(o => o.turmaId);

        }
    }
}
