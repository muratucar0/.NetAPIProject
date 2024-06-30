﻿using Businees.ValidationRules.FluentValidation;
using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Validation;
using Core.CrossCutingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using ValidationException = FluentValidation.ValidationException;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {

        private IProductDal _productDal;


        public ProductManager(IProductDal _productDal)
        {
            this._productDal = _productDal;  
        }


        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {


            //validation

            ValidationTool.Validate(new ProductValidator(), product);          
              
            _productDal.Add(product);

            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            { 
                   return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime); 
            } 
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListed);

        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
             return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=> p.CategoryId == id));
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult< Product >(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice == min && p.UnitPrice==max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }
    }
}