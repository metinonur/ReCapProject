using Core.DataAccess.EntityFramework;
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
                var result = from rent in context.Rentals
                            
                             select new RentalDetailDto
                             {
                                 RentalId = rent.Id,
                                 CarName = (from c in context.Cars where c.CarId==rent.CarId select c.CarName).Single(),
                                 CustomerFullName = (from c in context.Customers where c.Id == rent.CustomerId select c.CompanyName).Single(),
                                 RentDate = rent.RentDate,
                                 //RentStartDate = rent.RentStartDate,
                                 //RentEndDate = rent.RentEndDate,
                                 ReturnDate = rent.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
