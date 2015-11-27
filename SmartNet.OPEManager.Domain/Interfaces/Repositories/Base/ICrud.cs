using System.Collections.Generic;
using SmartNet.OPEManager.Domain.Entities.Base;

namespace SmartNet.OPEManager.Domain.Interfaces.Repositories.Base
{
    public interface ICrud<TEntity> where TEntity : class
    {
        TEntity Adicionar(TEntity obj);
        TEntity BuscarPorId(int id);
        ICollection<TEntity> BuscarTodos();
        TEntity Atualizar(TEntity obj);
        void Remover(TEntity obj);
        
    }
}
