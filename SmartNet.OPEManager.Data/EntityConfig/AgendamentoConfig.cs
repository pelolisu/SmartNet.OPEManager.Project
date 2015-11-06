using System.Data.Entity.ModelConfiguration;
using SmartNet.OPEManager.Model.Entities;

namespace SmartNet.OPEManager.Data.EntityConfig
{
    public class AgendamentoConfig : EntityTypeConfiguration<Agendamento>
    {
        public AgendamentoConfig()
        {
            ToTable("Agendamentos")
                .HasKey(o => new { o.data, o.horario });

           HasRequired(o => o.fase)
          .WithMany()
          .HasForeignKey(o => o.faseId);
        }
    }
}
