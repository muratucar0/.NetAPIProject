using Businees.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Businees.Concrete
{
    public class OrderManager : IOrderService
    {

        private IOrderDal order;

        public OrderManager(IOrderDal order)
        {
            this.order = order;
        }
        public void Add(Order entity)
        {
            order.Add(entity);

        }

        public void Delete(Order entity)
        {
            order.Delete(entity);
        }

     
        public List<Order> GetAll(Expression<Func<Order, bool>> filter = null  )
        {
              return order.GetAll(filter);
        }

        public Order GetById(int id)
        {
            return order.Get(o => o.OrderID == id); 
        }

        public void Update(Order entityt)
        {
              order.Update(entityt);
        }
    }
}
