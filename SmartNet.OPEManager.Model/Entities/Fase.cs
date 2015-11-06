using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNet.OPEManager.Model.Entities
{
    public class Fase
    {
        public int faseId { get; set; }
        public int semestreId { get; set; }
        public virtual Semestre semestre { get; set; }
        public int turmaId { get; set; }
        public virtual Turma turma { get; set; }
        public int projetoId { get; set; }
        public virtual Projeto projeto { get; set; }
    }
}
