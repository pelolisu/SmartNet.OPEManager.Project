
using System.Linq;
using SmartNet.OPEManager.Data.Contexto;
using SmartNet.OPEManager.Data.Repositories.Base;
using SmartNet.OPEManager.Domain.Entities;
using SmartNet.OPEManager.Domain.Interfaces.Repositories;
using System.Collections.Generic;

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

        public virtual ICollection<Curso> BuscarPorNome(string texto)
        {
            using (Db = new OPEModelContext())
            {
                return Db.Cursos.Where(o => o.nome.Contains(texto)).ToList();

            }

        }
    }
}
