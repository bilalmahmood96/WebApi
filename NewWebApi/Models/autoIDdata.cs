using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewWebApi.Models
{
    public class autoIDdata
    {
        public int autoID { get; set; }
    }
    public class autoIDDB
    {
        public static List<autoIDdata> mydb { get; set; }
    }
}