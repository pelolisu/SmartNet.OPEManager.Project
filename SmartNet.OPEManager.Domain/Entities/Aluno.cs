namespace SmartNet.OPEManager.Domain.Entities
{
    public class Aluno : Usuario
    {
        public int grupoId { get; set; }
        public virtual Grupo grupo { get; set; }
    }
}
