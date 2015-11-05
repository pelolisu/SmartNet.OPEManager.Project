using System.Data.Entity.ModelConfiguration;
using SmartNet.OPEManager.Model.Entities;

namespace SmartNet.OPEManager.Data.EntityConfig
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            ToTable("Usuários")
               .HasKey(o => o.RA);

            Property(o => o.nome)
                .HasMaxLength(255)
                .IsRequired();

            Property(o => o.email)
                .HasMaxLength(255)
                .IsRequired();

            Property(o => o.senha)
                .HasMaxLength(50)
                .IsRequired();

            Property(o => o.ativo)
              .IsRequired();

            
        }
    }
}
