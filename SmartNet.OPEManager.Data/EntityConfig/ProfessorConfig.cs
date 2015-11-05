using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartNet.OPEManager.Model.Entities;

namespace SmartNet.OPEManager.Data.EntityConfig
{
    public class ProfessorConfig : EntityTypeConfiguration<Professor>
    {
        public ProfessorConfig()
        {
            ToTable("Professores");
            //  .HasKey(o => o.RA);
           
        }
    }
}
