using System;

namespace SmartNet.OPEManager.Domain.Entities
{
    public class Turma : Base.Base
    {
        public int turmaId { get; set; }
        public string nome { get; set; }
        public DateTime dataCadastro { get; set; }
        
    }
}
