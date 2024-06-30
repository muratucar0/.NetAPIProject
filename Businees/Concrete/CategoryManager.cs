using Businees.Abstract;
using DataAccess.Abstract;
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
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal  categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }


        public void Add(Category entity)
        {
              categoryDal.Add(entity);  
        }

        public void Delete(Category entity)
        {
            categoryDal.Delete(entity); 
        }

        

      

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
             return categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
             return categoryDal.Get(c=> c.CategoryId == id);
        }

        public void Update(Category entityt)
        {
            throw new NotImplementedException();
        }
    }
}
