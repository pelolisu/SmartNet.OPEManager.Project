

using System.Collections.Generic;
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

        public virtual ICollection<Usuario> BuscarPorNome(string texto)
        {
            using (Db = new OPEModelContext())
            {
                return Db.Usuarios.Where(o => o.nome.Contains(texto)).ToList();

            }

        }

        public virtual ICollection<Usuario> BuscarPorEmail(string texto)
        {
            using (Db = new OPEModelContext())
            {
                return Db.Usuarios.Where(o => o.email.Contains(texto)).ToList();

            }

        }
    }
}
