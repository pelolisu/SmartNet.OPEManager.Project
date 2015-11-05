using System;
using System.Collections.Generic;

namespace SmartNet.OPEManager.Model.Entities
{
    public class Grupo
    {
        public int grupoId { get; set; }
        public string nome { get; set; }
        public DateTime dataCadastro { get; set; }
        public bool ativo { get; set; }
        public virtual IEnumerable<Aluno> alunos { get; set; }
        public virtual IEnumerable<Projeto> projetos { get; set; }

    }
}
