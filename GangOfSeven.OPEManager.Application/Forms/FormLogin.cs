using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartNet.OPEManager.Data.Repositories;
using SmartNet.OPEManager.Domain.Entities;

namespace GangOfSeven.OPEManager.Application.Forms
{
    class FormLogin
    {
        public Boolean fazerLogin(int ra, String senha)
        {
            var usuarioRep = new UsuarioRep().BuscarPorId(ra);

            if (usuarioRep.nome != null && usuarioRep.senha == senha)
            {
                return true;
            } else
            {
                return false;
            }
        }        
    }
}