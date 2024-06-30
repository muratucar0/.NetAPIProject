using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Businees.Abstract
{
    public  interface ICategoryService
    {
        List<Category> GetAll(Expression<Func<Category, bool>> filter = null);
        
        void Add(Category entity);
        void Update(Category entityt);

        void Delete(Category entity);

        Category GetById(int id);
    }
}
