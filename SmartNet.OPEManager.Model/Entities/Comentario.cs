
namespace SmartNet.OPEManager.Domain.Entities
{
    public class Comentario
    {
        public int comentarioId { get; set; }
        public string comentario { get; set; }
        public int agendamentoId { get; set; }
        public virtual Agendamento agendamento { get; set; }
        public int RA { get; set; }
        public virtual Usuario usuario { get; set; }
    }
}
