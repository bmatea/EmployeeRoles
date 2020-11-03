using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zadatak.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        int Add(TEntity entity);
        int Update(TEntity dbEntity, TEntity entity);
        int Delete(int id);
    }
}
