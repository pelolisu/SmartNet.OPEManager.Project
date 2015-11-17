using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SmartNet.OPEManager.Data.Contexto;
using SmartNet.OPEManager.Domain.Interfaces.Repositories.Base;

namespace SmartNet.OPEManager.Data.Repositories.Base
{
    public class Crud<TEntity> : ICrud<TEntity> where TEntity : class
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

        public ICollection<TEntity> BuscarTodos()
        {
            using (Db = new OPEModelContext())
            {
                return Db.Set<TEntity>().ToList();
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
