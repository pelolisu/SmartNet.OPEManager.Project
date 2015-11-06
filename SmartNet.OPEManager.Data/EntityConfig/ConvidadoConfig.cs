using System.Data.Entity.ModelConfiguration;
using SmartNet.OPEManager.Domain.Entities;

namespace SmartNet.OPEManager.Data.EntityConfig
{
    public class ConvidadoConfig : EntityTypeConfiguration<Convidado>
    {
        public ConvidadoConfig()
        {
            ToTable("Convidados")
                .HasKey(o => o.convidadoId);
            HasRequired(o => o.agendamento)
               .WithMany(o => o.convidados)
               .HasForeignKey(o => o.agendamentoId);
            HasRequired(o => o.usuario)
                .WithMany()
                .HasForeignKey(o => o.RA);
        }
    }
}
