
using System.Linq;
using SmartNet.OPEManager.Data.Contexto;
using SmartNet.OPEManager.Data.Repositories.Base;
using SmartNet.OPEManager.Domain.Entities;
using SmartNet.OPEManager.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace SmartNet.OPEManager.Data.Repositories
{
    public class GrupoRep : Crud<Grupo>, IGrupoRep
    {
        public new Grupo BuscarPorId(int id)
        {
            using (Db = new OPEModelContext())
            {
                Db.Grupos.Include("alunos").Include("projetos").ToList();
                return Db.Grupos.Find(id);

            }
        }

        public virtual ICollection<Grupo> BuscarPorNome(string texto)
        {
            using (Db = new OPEModelContext())
            {
                return Db.Grupos.Where(o => o.nome.Contains(texto)).ToList();

            }

        }
    }
}
