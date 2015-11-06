using System.Data.Entity.ModelConfiguration;
using SmartNet.OPEManager.Domain.Entities;

namespace SmartNet.OPEManager.Data.EntityConfig
{
    public class AlunoConfig : EntityTypeConfiguration<Aluno>
    {
        public AlunoConfig()
        {
            ToTable("Alunos")
            //Foreign Key Many - To - One
            .HasRequired(o => o.grupo)
                .WithMany(o => o.alunos)
                .HasForeignKey(o => o.grupoId);
        }
         
    }
}