using Newtonsoft.Json;
using NewWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
namespace NewWebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EditApiController : ApiController
    {
        
        [HttpPost]
        [Route("Api/Edit")]
        public string Edit(dataclass db)
        {
            var obj = DB.myDB.FindIndex(a => a.ID == db.ID);
            DB.myDB[obj] = db;
            Sync();
            return "Edited";
        }
        public void Sync()
        {
            var text = JsonConvert.SerializeObject(DB.myDB);
            string textFile = System.Web.Hosting.HostingEnvironment.MapPath("/Models/data.json"); ;
            System.IO.File.WriteAllText(textFile, text);
        }
        [HttpGet]
        [Route("Api/getID/{ID}")]
        public object getID (string ID) {
            var obj = DB.myDB.Find(a => a.ID == ID);
            return obj;
        }
    }
}
