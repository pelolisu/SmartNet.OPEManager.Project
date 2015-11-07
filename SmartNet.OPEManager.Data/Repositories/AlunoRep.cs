
using System.Linq;
using SmartNet.OPEManager.Data.Contexto;
using SmartNet.OPEManager.Data.Repositories.Base;
using SmartNet.OPEManager.Domain.Entities;
using SmartNet.OPEManager.Domain.Interfaces.Repositories;

namespace SmartNet.OPEManager.Data.Repositories
{
    public class AlunoRep : Crud<Aluno>, IAlunoRep
    {
        public new Aluno BuscarPorId(int id)
        {
            using (Db = new OPEModelContext())
            {
                Db.Alunos.Include("agendamentos").Include("grupo").ToList();
                return Db.Alunos.Find(id);

            }
        }
    }
}
