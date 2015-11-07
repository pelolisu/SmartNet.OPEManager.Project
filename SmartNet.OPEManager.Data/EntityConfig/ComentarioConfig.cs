
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
            Property(o => o.data)
                .IsRequired();

            //1:N - 1 comentário DEVE ter 1 agendamento e 1 agendamento pode ter muitos comentários
            HasRequired(o => o.agendamento)
                .WithMany(o => o.comentarios)
                .HasForeignKey(o => o.agendamentoId);

            //1:N - 1 comentario DEVE ter 1 usuário e 1 usuário pode ter muitos comentários
            HasRequired(o => o.usuario)
                .WithMany() 
                .HasForeignKey(o => o.RA);


        }
    }
}
