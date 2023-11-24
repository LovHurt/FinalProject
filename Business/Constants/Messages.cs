using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product has been added";
        public static string ProductNameInvalid = "Product name is invalid";
        public static string MaintenanceTime = "System is getting ready for ya";
        public static string ProductListed = "Products has been listed";

        public static string ProductCountOfCategoryError = "It can be maximum 10 products in one category";
        public static string ProductNameAlreadyExists = "This name already exists in another product name";
        public static string CategoryLimitExceded = "Category limit has been exceeded, so new product can not be added";
        public static string AuthorizationDenied = "You are not authorized";
        public static string UserRegistered = "User has been registered";
        public static string UserNotFound = "User can not be found";
        public static string PasswordError = "Password doesn't match";
        public static string SuccessfulLogin = "Login is successful";
        public static string UserAlreadyExists = "This username has been taken";
        public static string AccessTokenCreated = "Access token has been created";
    }
}
