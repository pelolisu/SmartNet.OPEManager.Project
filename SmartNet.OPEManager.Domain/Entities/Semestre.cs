using System;

namespace SmartNet.OPEManager.Domain.Entities
{
    public class Semestre : Base.Base
    {
        public int semestreId { get; set; }
        public string nome { get; set; }
        public DateTime dataCadastro { get; set; }
        public bool ativo { get; set; }
    }
}
