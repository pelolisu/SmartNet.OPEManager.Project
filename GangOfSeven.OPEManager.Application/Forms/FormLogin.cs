using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartNet.OPEManager.Data.Repositories;
using SmartNet.OPEManager.Domain.Entities;

namespace GangOfSeven.OPEManager.Application.Forms
{
    public class FormLogin
    {
        public Usuario fazerLogin(int ra)
        {
            Usuario usuario;

            usuario = new UsuarioRep().BuscarPorId(ra);

            return usuario;
        }
    }
}