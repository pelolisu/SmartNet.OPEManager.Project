using System.Collections.Generic;

namespace SmartNet.OPEManager.Model.Entities
{
    public class Projeto
    {
        public int projetoId { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string empresa { get; set; }
        public string urlSistema { get; set; }
        public int cursoId { get; set; }
        public int grupoId { get; set; }
        public virtual Grupo grupo { get; set; }
        public virtual Curso curso { get; set; }
        public virtual IEnumerable<Fase> fases { get; set; }
        public bool ativo { get; set; }

    }
}
