using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Businees.Abstract
{
    public interface ICustomerService
    {

        List<Customer> GetAll(Expression<Func<Category, bool>> filter = null);
        
        void Add(Customer entity);
        void Update(Customer entityt);

        void Delete(Customer entity);
    }
}
