﻿using Core.Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRegionDal : IEntityRepository<Region>
    {
    }
}
