
using System.Data.Entity.ModelConfiguration;
using SmartNet.OPEManager.Domain.Entities;

namespace SmartNet.OPEManager.Data.EntityConfig
{
    public class ComentarioConfig : EntityTypeConfiguration<Comentario>
    {
        public ComentarioConfig()
        {
            ToTable("Comentarios")
                .HasKey(o => o.comentarioId)
                .Property(o => o.comentario)
                .IsRequired()
                .HasMaxLength(2000);
            HasRequired(o => o.agendamento)
                .WithMany(o => o.comentarios)
                .HasForeignKey(o => o.agendamentoId);
            HasRequired(o => o.usuario)
                .WithMany()
                .HasForeignKey(o => o.RA);


        }
    }
}
