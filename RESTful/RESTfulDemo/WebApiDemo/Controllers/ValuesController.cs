using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        static List<string> data = initList();

        private static List<string> initList()
        {
            var ret = new List<string>();
            ret.Add("valuaue1");
            ret.Add("valau2");ret.Add("comment out [Autorize] above"); return ret;
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return data;//return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return data[id];//return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
