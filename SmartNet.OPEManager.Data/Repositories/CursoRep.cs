
using System.Linq;
using SmartNet.OPEManager.Data.Contexto;
using SmartNet.OPEManager.Data.Repositories.Base;
using SmartNet.OPEManager.Domain.Entities;
using SmartNet.OPEManager.Domain.Interfaces.Repositories;

namespace SmartNet.OPEManager.Data.Repositories
{
    public class CursoRep : Crud<Curso>, ICursoRep
    {
        public new Curso BuscarPorId(int id)
        {
            using (Db = new OPEModelContext())
            {
                Db.Cursos.Include("projetos").ToList();
                return Db.Cursos.Find(id);

            }
        }
    }
}
