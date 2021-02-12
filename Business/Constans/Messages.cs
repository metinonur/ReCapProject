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
        public static string UserAdded = "User added";
        public static string UserUpdated = "User updated";
        public static string UserDeleted = "User deleted";
        public static string UserListed = "User listed";
        public static string RentalAdded = "The rental is successful";
        public static string RentalAddedError = "It must be delivered before the vehicle is rented.";
        public static string RentalUpdateDate = "Date is updated successful";

    }
}
