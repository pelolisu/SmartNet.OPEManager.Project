
using System.Data.Entity.ModelConfiguration;
using SmartNet.OPEManager.Domain.Entities;

namespace SmartNet.OPEManager.Data.EntityConfig
{
    public class SemestreConfig : EntityTypeConfiguration<Semestre>
    {
        public SemestreConfig()
        {
            ToTable("Semestres")
                .HasKey(o => o.semestreId);
            Property(o => o.nome)
                .IsRequired()
                .HasMaxLength(255);
            Property(o => o.ativo)
                .IsRequired();
        }
    }
}
