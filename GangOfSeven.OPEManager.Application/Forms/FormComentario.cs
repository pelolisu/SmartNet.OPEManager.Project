using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartNet.OPEManager.Data.Repositories;
using SmartNet.OPEManager.Domain.Entities;

namespace GangOfSeven.OPEManager.Application.Forms
{
    class FormComentario
    {
        public void incluirComentario(Comentario comentario)
        {
            if (comentario != null)
            {
                new ComentarioRep().Adicionar(comentario);
            }
        }

        public void alterarComentario(Comentario comentario)
        {
            if (comentario != null)
            {
                new ComentarioRep().Atualizar(comentario);
            }
        }

        public void excluirComentario(int id)
        {

            var comentario = new ComentarioRep().BuscarPorId(id);
            comentario.ativo = false;
            new ComentarioRep().Atualizar(comentario);

        }

        public ICollection<Comentario> listarComentarios()
        {
            ICollection<Comentario> comentarios = new ComentarioRep().BuscarTodos();

            return comentarios;
        }

        public Comentario BuscarPorId(int id)
        {
            return new ComentarioRep().BuscarPorId(id);
        }
    }
}
