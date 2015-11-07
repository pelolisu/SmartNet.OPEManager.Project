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
            
            //1:N - 1 fase DEVE ter 1 projeto e 1 projeto pode ter muitas fases
            HasRequired(o => o.projeto)
                .WithMany(o => o.fases)
                .HasForeignKey(o => o.projetoId);

            //1:N - 1 fase DEVE ter 1 semestere e 1 semestre pode estar em muitas fases
            HasRequired(o => o.semestre)
               .WithMany()
               .HasForeignKey(o => o.semestreId);
            
            //1:N - 1 fase DEVE ter 1 turma e 1 turma pode estar em muitas fases
            HasRequired(o => o.turma)
            .WithMany()
            .HasForeignKey(o => o.turmaId);

        }
    }
}
