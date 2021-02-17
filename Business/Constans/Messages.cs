using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans
{
    public class Messages
    {
        public static string CarAdded = "Car added";
        public static string CarUpdated = "Car updated";
        public static string CarDeleted = "Car deleted";
        public static string CarListed = "Cars listed";
        public static string CarNameInvalid = ("The car has not been added! The car name must be at least 2 characters");
        public static string DailyPriceNotEnough = ("The daily price must be greater than 0!");
        public static string MaintenanceTime = "system is under maintenance ";
        public static string CarDetailListed = "Cars listed according to the requested information";
        public static string CarListedByBrandId = "Cars listed by Brand id";
        public static string CarListedByColorID = "Cars listed by Color id";
        public static string CarListedByCarId = "Cars listed by Car id";
        //Color messages
        public static string ColorAdded = "Color added";
        public static string ColorUpdated = "Color updated";
        public static string ColorDeleted = "Color deleted";
        public static string ColorsListed = "Colors listed";
        public static string ColorDeletedById = "Color deleted by Color id";
        //Brand messages
        public static string BrandAdded = "Brand added";
        public static string BrandUpdated = "Brand updated";
        public static string BrandDeleted = "Brand deleted";
        public static string BrandListed = "Brands listed";
        public static string BrandListedByBrandId = "Brands listed by Brand id";

        //User messages
        public static string UserAdded = "User added";
        public static string UserUpdated = "User updated";
        public static string UserDeleted = "User deleted";
        public static string UserListed = "Users listed";
        public static string UserListedById = "Users listed by User id";
        //Rental messages
        public static string RentalAdded = "The rental is successful";
        public static string RentalAddedError = "It must be delivered before the vehicle is rented.";
        public static string RentalUpdateDate = "Date is updated successful";
        //Customer messages
        public static string CustomerAdded = "Customer added";
        public static string CustomerUpdated = "Customer updated";
        public static string CustomerDeleted = "Customer deleted";
        public static string CustomerListed = "Customers listed";
        public static string CustomerListedById = "Customers listed by Customer id";



    }
}
