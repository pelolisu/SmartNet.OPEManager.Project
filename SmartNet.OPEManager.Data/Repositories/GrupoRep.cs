
using System.Linq;
using SmartNet.OPEManager.Data.Contexto;
using SmartNet.OPEManager.Data.Repositories.Base;
using SmartNet.OPEManager.Domain.Entities;
using SmartNet.OPEManager.Domain.Interfaces.Repositories;

namespace SmartNet.OPEManager.Data.Repositories
{
    public class GrupoRep : Crud<Grupo>, IGrupoRep
    {
        public Grupo BuscarPorId(int id)
        {
            using (Db = new OPEModelContext())
            {
                Db.Grupos.Include("alunos").Include("projetos").ToList();
                return Db.Grupos.Find(id);

            }
        }
    }
}
