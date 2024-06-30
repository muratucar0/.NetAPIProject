using Core.Entities;
using System.Linq.Expressions;

namespace Core.Entities
{

    // core not reference
    public interface IEntityRepository<T> where T : class , IEntity  ,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null) ;
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entityt);

        void Delete(T entity);

    
      
    }
}
