using System.Collections.Generic;

namespace SmartNet.OPEManager.Domain.Entities
{
    public class Projeto : Base.Base
    {
        public int projetoId { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string empresa { get; set; }
        public string urlSistema { get; set; }
        public int grupoId { get; set; }
        public int cursoId { get; set; }
        public virtual Grupo grupo { get; set; }
        public virtual Curso curso { get; set; }
        public virtual ICollection<Fase> fases { get; set; }
       

    }
}
