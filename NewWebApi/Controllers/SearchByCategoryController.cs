using NewWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewWebApi.Controllers
{
    public class SearchByCategoryController : ApiController
    {
        [HttpGet]
        public List<dataclass> datastatusbyCategories(string Categories)
        {
            return DB.myDB.Where(a => a.Categories.Contains(Categories)).ToList();
        }
    }
}
