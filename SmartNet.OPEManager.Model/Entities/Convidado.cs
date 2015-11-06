
namespace SmartNet.OPEManager.Domain.Entities
{
    public class Convidado
    {
        public int convidadoId { get; set; }
        public int RA { get; set; }
        public virtual Usuario usuario { get; set; }
        public int agendamentoId { get; set; }
        public virtual Agendamento agendamento { get; set; }
    }
}
