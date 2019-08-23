using NewWebApi.Models;
using System.Web.Http.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace NewWebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods:"*")]
    public class SearchByCategoryController : ApiController
    {
        [HttpGet]
        [Route("api/Hello")]
        public object datastatusbyCategories(string Categories)
        {
            return DB.myDB.Where(a => a.Categories.Contains(Categories)).ToList();


        }

    }
}
