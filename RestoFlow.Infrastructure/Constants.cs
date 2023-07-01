namespace RestoFlow.Infrastructure
{
    public class Constants
    {
        public class User
        {
            public const int FirstNameMaxLength = 50;
            public const int FirstNameMinLength = 2;
            public const int LastNameMaxLength = 50;
            public const int LastNameMinLength = 2;
            public const int UsernameMinLength = 5;
            public const int UsernameMaxLength = 20;

            public const string RoleRequiredErrorMessage = "Role is required.";
            public const string FirstNameRequiredErrorMessage = "First name is required.";
            public const string FirstNameLengthErrorMessage = "First name must be between {0} and {1} characters long.";
            public const string LastNameRequiredErrorMessage = "Last name is required.";
            public const string LastNameLengthErrorMessage = "Last name must be between {0} and {1} characters long.";
            public const string UsernameRequiredErrorMessage = "Username is required.";
            public const string UsernameLengthErrorMessage = "Username must be between {0} and {1} characters long.";

        }

        public class Role
        {
            public const int RoleNameMinLength = 2;
            public const int RoleNameMaxLength = 50;

            public const string RoleNameRequiredErrorMessage = "Role name is required.";
            public const string RoleNameLengthErrorMessage = "Role name must be between {0} and {1} characters long.";
        }

        public class Table
        {

            public const string TableNumberRequiredErrorMessage = "Table name is required.";
            public const string TableSeatsRequiredErrorMessage = "Table seats is required.";
            public const string TableExistsErrorMessage = "Table with the same table number already exists.";

        }

        public class Order
        {
            public const int OrderInfoMinLength = 2;
            public const int OrderInfoMaxLength = 100;
            public const int OrderProductQuantityMinLength = 1;
            public const int OrderProductQuantityMaxLength = 100;

            public const string OrderInfoLengthErrorMessage = "Info must be between {0} and {1} characters long.";
            public const string OrderProductQuantityLengthErrorMessage = "Order quantity must be between {0} and {1}.";
        }

        public class Product
        {
            public const int ProductNameMinLength = 2;
            public const int ProductNameMaxLength = 50;
            public const int ProductDescriptionMinLength = 10;
            public const int ProductDescriptionMaxLength = 500;
            public const int ProductPriceMinValue = 0;
            public const decimal ProductPriceMaxValue = decimal.MaxValue;
            public const int ProductPricePrecision = 0;




            public const string ProductPriceRequireErrorMessage = "Price is required";
            public const string ProductPriceRangeErrorMessage = "Price must be a positive number";
            public const string ProductNameRequiredErrorMessage = "Product name is required.";
            public const string ProductDescriptionRequiredErrorMessage = "Product description is required.";
            public const string ProductNameLengthErrorMessage = "Product name must be between {0} and {1} characters long.";
            public const string ProductDescriptionLengthErrorMessage = "Product description must be between {0} and {1} characters long.";
            public const string ProductCategoryIdRequiredErrorMessage = "Category ID is required.";
        }

        public class Category
        {
            public const int CategoryNameMinLength = 2;
            public const int CategoryNameMaxLength = 50;

            public const string CategoryNameRequiredErrorMessage = "Category name is required.";
            public const string CategoryNameLengthErrorMessage = "Category name must be between {0} and {1} characters long.";
        }

        public class Reservation
        {
            public const int PartySizeMaxValue = 50;
            public const int PartySizeMinValue = 1;

            public const string UserRequiredErrorMessage = "User is required.";
            public const string ReservationDateRequiredErrorMessage = "Reservation date is required.";
            public const string PartySizeErrorMessage = "Party size must be between {0} and {1}.";
        }
    }
}
