using System;

namespace SmartNet.OPEManager.Model.Entities
{
   public class Agendamento
    {
        public DateTime data { get; set; }
        public TimeSpan horario { get; set; }
        public string assunto { get; set; }

    }
}
