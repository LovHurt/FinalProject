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
        public static string CategoryLimitExceded = "Category limit has been exceded, so new product can not be added"
    }
}
