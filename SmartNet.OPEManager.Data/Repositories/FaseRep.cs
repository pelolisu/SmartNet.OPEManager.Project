
using System.Linq;
using SmartNet.OPEManager.Data.Contexto;
using SmartNet.OPEManager.Data.Repositories.Base;
using SmartNet.OPEManager.Domain.Entities;
using SmartNet.OPEManager.Domain.Interfaces.Repositories;

namespace SmartNet.OPEManager.Data.Repositories
{
    public class FaseRep : Crud<Fase>, IFaseRep
    {
        public new Fase BuscarPorId(int id)
        {
            using (Db = new OPEModelContext())
            {
                Db.Fases.Include("agendamentos").Include("semestre").Include("turma").Include("projeto").ToList();
                return Db.Fases.Find(id);

            }
        }
    }
}
