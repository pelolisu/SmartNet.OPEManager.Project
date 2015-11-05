using System;
using System.Collections.Generic;

namespace SmartNet.OPEManager.Model.Entities
{
    public class Curso
    {
        public int cursoId { get; set; }
        public string nome { get; set; }
        public DateTime dataCadastro { get; set; }
        public virtual IEnumerable<Projeto> projetos { get; set; }
        public bool ativo { get; set; }
    }
}
