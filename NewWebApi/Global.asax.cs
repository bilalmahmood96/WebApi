using Newtonsoft.Json;
using NewWebApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace NewWebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            string textFile = Server.MapPath("/Models/data.json");
            if (File.Exists(textFile))
            {
                // Read entire text file content in one string  
                string text = File.ReadAllText(textFile);
                DB.myDB = JsonConvert.DeserializeObject<List<dataclass>>(text);
            }
            string textFile1 = Server.MapPath("/Models/Categorydata.json");
            if (File.Exists(textFile1))
            {
                string text1 = File.ReadAllText(textFile1);
                Cat.Catdata = JsonConvert.DeserializeObject<List<Category>>(text1);
            }
        }
    }
}
