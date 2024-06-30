using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businees.Abstract
{
    public interface IRegionService
    {
        List<Region> GetAll();
        void Add(Region product);
        void Update(Region product);

        void Delete(Region product);


        Region GetById(int id);
    }
}
