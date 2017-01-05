using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class HelloApiController : ApiController
    {
        // type: api/HelloApi to get json 
        //public string Get()
        //{
        //    return "hello from API at " + DateTime.Now.ToString();
        //}

        public IHttpActionResult Get()
        {
            return Ok(new []{ "a", "b" });
        }
    }
}
