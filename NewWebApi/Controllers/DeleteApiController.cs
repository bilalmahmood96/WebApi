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
    public class DeleteApiController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpPost]
        [Route("api/DeleteItem/{ID}")]
        public object DeleteItem(string ID)
        {
            var obj = DB.myDB.Find(a => a.ID == ID);
            DB.myDB.Remove(obj);
            Sync();
            return DB.myDB;

        }
        public void Sync()
        {

            var text = JsonConvert.SerializeObject(DB.myDB);
            string textFile = System.Web.Hosting.HostingEnvironment.MapPath("/Models/data.json");
            System.IO.File.WriteAllText(textFile, text);
        }
    }
}
