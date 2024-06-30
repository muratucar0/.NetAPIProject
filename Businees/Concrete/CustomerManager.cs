using Businees.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Businees.Concrete
{
    public class CustomerManager : ICustomerService
    {

        private EfCustomerDal customerDal;

        public CustomerManager(EfCustomerDal customerDal)
        {
            this.customerDal = customerDal;  
        }
        public void Add(Customer entity)
        {
              customerDal.Add(entity);
        }

        public void Delete(Customer entity)
        {
             customerDal.Delete(entity);
        }

         

        public List<Customer> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return customerDal.GetAll();
        }

        public void Update(Customer entityt)
        {
             customerDal.Update(entityt);
        }
    }
}
