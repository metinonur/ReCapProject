﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<RentalDetailDto>> GetRentalDetailsDto();
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult CheckReturnDate(int carId);
        IResult UpdateReturnDate(int carId);
    }
}
