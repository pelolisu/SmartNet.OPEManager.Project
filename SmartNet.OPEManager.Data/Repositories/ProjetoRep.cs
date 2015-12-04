
using System.Linq;
using SmartNet.OPEManager.Data.Contexto;
using SmartNet.OPEManager.Data.Repositories.Base;
using SmartNet.OPEManager.Domain.Entities;
using SmartNet.OPEManager.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace SmartNet.OPEManager.Data.Repositories
{
    public class ProjetoRep : Crud<Projeto>, IProjetoRep
    {
        public new Projeto BuscarPorId(int id)
        {
            using (Db = new OPEModelContext())
            {
                Db.Projetos.Include("fases").Include("grupo").Include("curso").ToList();
                return Db.Projetos.Find(id);

            }
        }

        public virtual ICollection<Projeto> BuscarPorTitulo(string texto)
        {
            using (Db = new OPEModelContext())
            {
                return Db.Projetos.Where(o => o.titulo.Contains(texto)).ToList();

            }
        }

        public virtual ICollection<Projeto> BuscarPorDescricao(string texto)
        {
            using (Db = new OPEModelContext())
            {
                return Db.Projetos.Where(o => o.descricao.Contains(texto)).ToList();

            }

        }
    }
}
