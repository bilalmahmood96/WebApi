using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewWebApi.Models
{
    public class dataclass
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public List<string> Categories { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int RetailPrice { get; set; }
        public string LastUpdateDate { get; set; }
        public string LastUpdateby { get; set; }
    }
    public class DB
    {
        public static List<dataclass> myDB { get; set; }
    }
}
