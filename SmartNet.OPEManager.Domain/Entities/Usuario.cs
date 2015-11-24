using System;
using System.Collections.Generic;

namespace SmartNet.OPEManager.Domain.Entities
{
    public class Usuario
    {
        public enum Perfil:int {Administrador = 1, Usuario = 2};
        public int RA { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public DateTime dataCadastro { get; set; }
        public Perfil perfil { get; set; }
        public bool ativo { get; set; }
        public virtual ICollection<Agendamento> agendamentos { get; set; }
        public bool visualizacao { get; set; }


    }
}
