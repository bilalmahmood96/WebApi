using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewWebApi.Models
{
    public class Category
    {
        public string categoryID { get; set; }
        public string categoryName { get; set; }
    }
    public class Cat
    {
        public static List<Category> Catdata { get; set; }
    }
}