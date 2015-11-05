using System;

namespace SmartNet.OPEManager.Model.Entities
{
    public class Semestre
    {
        public int semestreId { get; set; }
        public string nome { get; set; }
        public DateTime dataCadastro { get; set; }
        public bool ativo { get; set; }
    }
}
