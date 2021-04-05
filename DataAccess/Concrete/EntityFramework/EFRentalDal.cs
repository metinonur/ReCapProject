﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFRentalDal : EFEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {

            using (ReCapContext context = new ReCapContext())
            {
                var result = from re in  context.Rentals 
                             join ca in context.Cars on re.CarId equals ca.CarId
                             join cus in context.Customers on re.CustomerId equals cus.Id 
                             join us in context.Users on cus.UserId equals us.Id
                             join bra in context.Brands on ca.BrandId equals bra.BrandId



                             select new RentalDetailDto
                             {
                                 Id = re.Id,
                                 CarName = ca.CarName,
                                 BrandName= bra.BrandName,
                                 CustomerName = cus.CompanyName,
                                 CarId = ca.CarId,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate,
                                 UserName = us.FirstName + " " + us.LastName
                             };

                return result.ToList();
            }
        }
    }
}
