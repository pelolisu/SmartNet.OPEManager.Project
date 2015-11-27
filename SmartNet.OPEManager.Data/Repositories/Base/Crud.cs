using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SmartNet.OPEManager.Data.Contexto;
using SmartNet.OPEManager.Domain.Interfaces.Repositories.Base;
using SmartNet.OPEManager.Domain.Entities.Base;

namespace SmartNet.OPEManager.Data.Repositories.Base
{
    public class Crud<TEntity> : ICrud<TEntity> where TEntity : Domain.Entities.Base.Base
    {

        protected OPEModelContext Db;

        public TEntity Adicionar(TEntity obj)
        {
            using (Db = new OPEModelContext())
            {
                Db.Set<TEntity>().Add(obj);
                Db.SaveChanges();
                return obj;
            }
        }

        public TEntity BuscarPorId(int id)
        {
            using (Db = new OPEModelContext())
            {
                return Db.Set<TEntity>().Find(id);
            }
        }

        public virtual ICollection<TEntity> BuscarTodos()
        {
            using (Db = new OPEModelContext())
            {
                return Db.Set<TEntity>().Where(m => m.ativo).ToList();
            }
        }

        public TEntity Atualizar(TEntity obj)
        {
            using (Db = new OPEModelContext())
            {
                Db.Entry(obj).State = EntityState.Modified;
                Db.SaveChanges();
                return obj;
            }
        }

        public void Remover(TEntity obj)
        {
            using (Db = new OPEModelContext())
            {
                Db.Entry(obj).State = EntityState.Deleted;
                Db.SaveChanges();
            }
        }
        
    }
}
