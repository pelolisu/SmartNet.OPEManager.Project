
using System.Linq;
using SmartNet.OPEManager.Data.Contexto;
using SmartNet.OPEManager.Data.Repositories.Base;
using SmartNet.OPEManager.Domain.Entities;
using SmartNet.OPEManager.Domain.Interfaces.Repositories;
using System.Collections.Generic;

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

        public virtual ICollection<Aluno> BuscarPorNome(string texto)
        {
            using (Db = new OPEModelContext())
            {
                return Db.Alunos.Where(o => o.nome.Contains(texto)).ToList();

            }

        }
    }
}
