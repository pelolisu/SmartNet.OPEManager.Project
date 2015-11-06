using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartNet.OPEManager.Model.Entities;

namespace SmartNet.OPEManager.Data.EntityConfig
{
    public class FaseConfig : EntityTypeConfiguration<Fase>
    {
        public FaseConfig()
        {
            ToTable("Fases")
             .HasKey(o => new { o.semestreId, o.turmaId, o.projetoId });
            HasRequired(o => o.projeto)
                .WithMany()
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
