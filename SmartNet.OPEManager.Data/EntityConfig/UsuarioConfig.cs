using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SmartNet.OPEManager.Domain.Entities;

namespace SmartNet.OPEManager.Data.EntityConfig
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            ToTable("Usuarios")
                .HasKey(o => o.RA);
            Property(o => o.RA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
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

            Property(o => o.visualizacao)
              .IsRequired();


        }
    }
}
