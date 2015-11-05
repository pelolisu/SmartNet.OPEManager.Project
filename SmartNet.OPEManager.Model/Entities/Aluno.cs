using SmartNet.OPEManager.Model;

namespace SmartNet.OPEManager.Model.Entities
{
    public class Aluno : Usuario
    {
        public int grupoId { get; set; }
        public virtual Grupo grupo { get; set; }
    }
}
