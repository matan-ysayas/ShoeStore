using ShoeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoeStore.Controllers.api
{
    public class ElegantShoeController : ApiController
    {
        ShoeStoreDataContext ShoeStoreDB=new ShoeStoreDataContext();
        // GET: api/ElegantShoe
        public IHttpActionResult Get()
        {

            return Ok(ShoeStoreDB.ElegantShoes.ToList());
        }

        // GET: api/ElegantShoe/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ElegantShoe
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ElegantShoe/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ElegantShoe/5
        public void Delete(int id)
        {
        }
    }
}
