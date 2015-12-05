using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartNet.OPEManager.Data.Repositories;
using SmartNet.OPEManager.Domain.Entities;

namespace GangOfSeven.OPEManager.Application.Forms
{
    public class FormUsuario
    {
        public void incluirUsuario(Usuario usuario)
        {
            if (usuario != null)
            {
                new UsuarioRep().Adicionar(usuario);
            }
        }

        public void alterarUsuario(Usuario usuario)
        {
            if (usuario != null)
            {
                new UsuarioRep().Atualizar(usuario);
            }
        }

        public void excluirUsuario(int ra)
        {
            var usuario = new UsuarioRep().BuscarPorId(ra);

            usuario.ativo = false;

            new UsuarioRep().Atualizar(usuario);
        }

        public ICollection<Usuario> listarLogin()
        {
            ICollection<Usuario> usuarios = new UsuarioRep().BuscarTodos();

            return usuarios;
        }

        public Usuario buscaUsuario(int id)
        {
            return new UsuarioRep().BuscarPorId(id);
        }

        public ICollection<Usuario> buscaEmailUsuario(string email)
        {
            ICollection<Usuario> emailUsuarios = null;

            if (email != null)
            {
                emailUsuarios = new UsuarioRep().BuscarPorEmail(email);
            }

            return emailUsuarios;
        }

        public ICollection<Usuario> buscaNomeUsuario(string nome)
        {
            ICollection<Usuario> nomeUsuarios = null;

            if (nome != null)
            {
                nomeUsuarios = new UsuarioRep().BuscarPorNome(nome);
            }

            return nomeUsuarios;
        }
    }
}