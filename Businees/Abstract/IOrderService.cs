using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Businees.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll(Expression<Func<Order, bool>> filter = null);

        void Add(Order entity);
        void Update(Order entityt);

        void Delete(Order entity);


        Order GetById(int id);

        
    }
}
