
using System.Linq;
using SmartNet.OPEManager.Data.Contexto;
using SmartNet.OPEManager.Data.Repositories.Base;
using SmartNet.OPEManager.Domain.Entities;
using SmartNet.OPEManager.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace SmartNet.OPEManager.Data.Repositories
{
    public class ProfessorRep : Crud<Professor>, IProfessorRep
    {
        public new Professor BuscarPorId(int id)
        {
            using (Db = new OPEModelContext())
            {
                Db.Professores.Include("agendamentos").ToList();
                return Db.Professores.Find(id);

            }
        }

        public virtual ICollection<Professor> BuscarPorNome(string texto)
        {
            using (Db = new OPEModelContext())
            {
                return Db.Professores.Where(o => o.nome.Contains(texto)).ToList();

            }

        }
    }
}
