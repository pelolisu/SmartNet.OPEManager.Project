
using System.Linq;
using SmartNet.OPEManager.Data.Contexto;
using SmartNet.OPEManager.Data.Repositories.Base;
using SmartNet.OPEManager.Domain.Entities;
using SmartNet.OPEManager.Domain.Interfaces.Repositories;

namespace SmartNet.OPEManager.Data.Repositories
{
    public class ComentarioRep : Crud<Comentario>, IComentarioRep
    {
        public new Comentario BuscarPorId(int id)
        {
            using (Db = new OPEModelContext())
            {
                Db.Comentarios.Include("agendamento").Include("usuario").ToList();
                return Db.Comentarios.Find(id);

            }
        }
    }
}
