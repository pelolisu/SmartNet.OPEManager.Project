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
        public String fazerLogin(int ra, String senha)
        {
            var usuarioRep = new UsuarioRep().BuscarPorId(ra);

            if (usuarioRep.RA.ToString().Equals(ra.ToString()) && usuarioRep.senha.Equals(senha))
            {
                if (usuarioRep.ativo == true)
                {
                    return "OK";
                } else
                {
                    return "BLOQUEADO";
                }
            }
            else
            {
                return "NOK";
            }
        }

        public String retornaPerfil(int ra)
        {
            var usuarioRep = new UsuarioRep().BuscarPorId(ra);

            return usuarioRep.perfil.ToString();
        }
    }
}