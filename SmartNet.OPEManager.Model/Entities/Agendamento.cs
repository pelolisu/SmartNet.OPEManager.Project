using System;
using System.Collections.Generic;

namespace SmartNet.OPEManager.Domain.Entities
{
   public class Agendamento
    {
        public int agendamentoId { get; set; }
        public DateTime data { get; set; }
        public TimeSpan horario { get; set; }
        public string assunto { get; set; }
        public int faseId { get; set; }
        public virtual Fase fase { get; set; }
        public virtual ICollection<Usuario> convidados { get; set; }
        public virtual ICollection<Comentario> comentarios { get; set; }

       public Agendamento()
       {
           convidados = new List<Usuario>();
       }
    }
}
