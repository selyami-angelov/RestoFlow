﻿namespace RestoFlow.Infrastructure
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
            public const int TableNameMinLength = 2;
            public const int TableNameMaxLength = 50;

            public const string TableNameRequiredErrorMessage = "Table name is required.";
            public const string TableNameLengthErrorMessage = "Table name must be between {0} and {1} characters long.";
        }

        public class Order
        {
            public const int ProductInfoMinLength = 2;
            public const int ProductInfoMaxLength = 100;

            public const string ProductInfoRequiredErrorMessage = "Info is required.";
            public const string ProductInfoLengthErrorMessage = "Info must be between {0} and {1} characters long.";
        }

        public class Product
        {
            public const int ProductNameMinLength = 2;
            public const int ProductNameMaxLength = 50;
            public const int ProductDescriptionMinLength = 10;
            public const int ProductDescriptionMaxLength = 500;

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
    }
}