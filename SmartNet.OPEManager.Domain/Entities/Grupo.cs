﻿using System;
using System.Collections.Generic;

namespace SmartNet.OPEManager.Domain.Entities
{
    public class Grupo
    {
        public int grupoId { get; set; }
        public string nome { get; set; }
        public DateTime dataCadastro { get; set; }
        public bool ativo { get; set; }
        public virtual ICollection<Aluno> alunos { get; set; }
        public virtual ICollection<Projeto> projetos { get; set; }

    }
}