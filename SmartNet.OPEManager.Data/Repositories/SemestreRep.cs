
using System.Collections.Generic;
using System.Linq;
using SmartNet.OPEManager.Data.Contexto;
using SmartNet.OPEManager.Data.Repositories.Base;
using SmartNet.OPEManager.Domain.Entities;
using SmartNet.OPEManager.Domain.Interfaces.Repositories;

namespace SmartNet.OPEManager.Data.Repositories
{
    public class SemestreRep : Crud<Semestre>, ISemestreRep
    {
        public virtual ICollection<Semestre> BuscarPorNome(string texto)
        {
            using (Db = new OPEModelContext())
            {
                return Db.Semestres.Where(o => o.nome.Contains(texto)).ToList();

            }

        }
    }
}
