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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from r in filter == null ? context.Rentals : context.Rentals.Where(filter)
                             join cus in context.Customers
                             on r.CustomerId equals cus.UserId
                             join u in context.Users
                             on cus.UserId equals u.UserId
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             select new RentalDetailDto
                             {
                                 CarId = r.CarId,
                                 CarName = c.CarName,
                                 CustomerFirstName = u.FirstName,
                                 CustomerLastName = u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = (DateTime)r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
