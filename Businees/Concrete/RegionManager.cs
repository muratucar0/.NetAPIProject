using Businees.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businees.Concrete
{
    public class RegionManager : IRegionService
    {

        private IRegionDal _regionDal;

        public RegionManager(IRegionDal _regionDal)
        {
            this._regionDal = _regionDal;
        }
        public void Add(Region product)
        {
            _regionDal.Add(product);
        }

        public void Delete(Region product)
        {
            _regionDal.Delete(product);
        }

        public List<Region> GetAll()
        {
            return _regionDal.GetAll(); 
        }

        public Region GetById(int id)
        {
           return  _regionDal.Get(r => r.RegionID == id);
        }

        public void Update(Region product)
        {
              _regionDal.Update(product);
        }
    }
}
