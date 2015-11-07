

using System.Linq;
using SmartNet.OPEManager.Data.Contexto;
using SmartNet.OPEManager.Data.Repositories.Base;
using SmartNet.OPEManager.Domain.Entities;
using SmartNet.OPEManager.Domain.Interfaces.Repositories;

namespace SmartNet.OPEManager.Data.Repositories
{
    public class UsuarioRep : Crud<Usuario>, IUsuarioRep
    {
        public new Usuario BuscarPorId(int id)
        {
            using (Db = new OPEModelContext())
            {
                Db.Usuarios.Include("agendamentos").ToList();
                return Db.Usuarios.Find(id);

            }
        }
    }
}
