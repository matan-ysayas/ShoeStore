using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoeStore.Controllers.api
{
    public class SportShoeController : ApiController
    {
        // GET: api/SportShoe
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SportShoe/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SportShoe
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SportShoe/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SportShoe/5
        public void Delete(int id)
        {
        }
    }
}
