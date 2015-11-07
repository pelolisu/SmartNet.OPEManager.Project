using System.Data.Entity.ModelConfiguration;
using SmartNet.OPEManager.Domain.Entities;

namespace SmartNet.OPEManager.Data.EntityConfig
{
    public class AgendamentoConfig : EntityTypeConfiguration<Agendamento>
    {
        public AgendamentoConfig()
        {
            ToTable("Agendamentos")
                .HasKey(o => o.agendamentoId)
                .Property(o => o.assunto)
                .IsRequired()
                .HasMaxLength(400);
            HasRequired(o => o.fase)
                .WithMany(o => o.agendamentos)
                .HasForeignKey(o => o.faseId);

            //N:N
            HasMany(o => o.convidados)
            .WithMany(o => o.agendamentos)
            .Map(o =>
            {
                o.MapLeftKey("agendamentoId");
                o.MapRightKey("RA");
                o.ToTable("Convidados");
            });
        }
    }
}
