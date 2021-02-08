﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public void DeleteById(int brandId)
        {
            _brandDal.Delete(_brandDal.Get(b=>b.BrandId==brandId));
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetByBrandName(string brandName)
        {
          return  _brandDal.Get(b=>b.BrandName==brandName);
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b=>b.BrandId==brandId);
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }
}
