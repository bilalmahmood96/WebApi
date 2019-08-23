using Newtonsoft.Json;
using NewWebApi.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NewWebApi.Controllers
{
    public class CreateApiController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpPost]
        [Route("api/Create/")]
        public object CreateView(dataclass db)
        {
            if (db.ID == null)
            {
                string ID = WebConfigurationManager.AppSettings["id"];
                int conID = Convert.ToInt32(ID);
                Configuration config = WebConfigurationManager.OpenWebConfiguration("~");
                //System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                conID++;
                config.AppSettings.Settings["id"].Value = conID.ToString();
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                db.ID = "ITM00" + ID;
                DB.myDB.Add(db);
                Sync();
                return db;
            }
            return db;

        }
        public void Sync()
        {
            var text = JsonConvert.SerializeObject(DB.myDB);
            string textFile = System.Web.Hosting.HostingEnvironment.MapPath("/Models/data.json"); ;
            System.IO.File.WriteAllText(textFile, text);

        }
        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/dropdown")]
        public object dropdown() {
            return Cat.Catdata;
        }

    }
}
