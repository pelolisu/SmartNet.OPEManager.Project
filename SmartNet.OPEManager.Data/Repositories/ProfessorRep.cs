
using System.Linq;
using SmartNet.OPEManager.Data.Contexto;
using SmartNet.OPEManager.Data.Repositories.Base;
using SmartNet.OPEManager.Domain.Entities;
using SmartNet.OPEManager.Domain.Interfaces.Repositories;

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
    }
}
