using System.Data.Entity.ModelConfiguration;
using SmartNet.OPEManager.Model.Entities;

namespace SmartNet.OPEManager.Data.EntityConfig
{
    public class AlunoConfig : EntityTypeConfiguration<Aluno>
    {
        public AlunoConfig()
        {
            ToTable("Alunos");
            HasKey(o => o.RA)
            //Foreign Key Many - To - One
            .HasRequired(o => o.grupo)
                .WithMany()
                .HasForeignKey(o => o.grupoId);
        }
         
    }
}