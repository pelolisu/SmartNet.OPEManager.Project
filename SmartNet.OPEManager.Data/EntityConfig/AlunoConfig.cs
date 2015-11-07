using System.Data.Entity.ModelConfiguration;
using SmartNet.OPEManager.Domain.Entities;

namespace SmartNet.OPEManager.Data.EntityConfig
{
    public class AlunoConfig : EntityTypeConfiguration<Aluno>
    {
        public AlunoConfig()
        {
            ToTable("Alunos")
                .HasKey(o => o.RA);
            
            //1:N - 1 aluno DEVE ter 1 grupo e 1 grupo pode ter muitos alunos
            HasRequired(o => o.grupo)
                .WithMany(o => o.alunos)
                .HasForeignKey(o => o.grupoId);
            }

    }
}