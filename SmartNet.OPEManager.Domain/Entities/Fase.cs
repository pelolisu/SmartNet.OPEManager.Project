using System.Collections.Generic;

namespace SmartNet.OPEManager.Domain.Entities
{
    public class Fase : Base.Base
    {
        public int faseId { get; set; }
        public int semestreId { get; set; }
        public virtual Semestre semestre { get; set; }
        public int turmaId { get; set; }
        public virtual Turma turma { get; set; }
        public int projetoId { get; set; }
        public virtual Projeto projeto { get; set; }
        public virtual ICollection<Agendamento> agendamentos {get;set;}
    }
}
