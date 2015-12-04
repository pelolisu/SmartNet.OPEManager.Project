using System.Collections.Generic;
using System.Linq;
using SmartNet.OPEManager.Data.Contexto;
using SmartNet.OPEManager.Data.Repositories.Base;
using SmartNet.OPEManager.Domain.Entities;
using SmartNet.OPEManager.Domain.Interfaces.Repositories;

namespace SmartNet.OPEManager.Data.Repositories
{
    public class TurmaRep : Crud<Turma>, ITurmaRep
    {
        public virtual ICollection<Turma> BuscarPorNome(string texto)
        {
            using (Db = new OPEModelContext())
            {
                return Db.Turmas.Where(o => o.nome.Contains(texto)).ToList();

            }

        }
    }
}
