using ShoeStore.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
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
        public async Task<IHttpActionResult> Get(int id)
        {

            try
            {
                return Ok(await ShoeStoreDB.ElegantShoes.FindAsync(id));
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // POST: api/ElegantShoe
        public async Task<IHttpActionResult> Post([FromBody]ElegantShoe value)
        {
            try
            {
                ShoeStoreDB.ElegantShoes.Add(value);
                await ShoeStoreDB.SaveChangesAsync();
                return Ok("item was add");
                    
            }catch(SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/ElegantShoe/5
        public async Task<IHttpActionResult> Put(int id, [FromBody] ElegantShoe value)
        {
            try
            {
                ElegantShoe elegantShoe = await ShoeStoreDB.ElegantShoes.FindAsync(id);
                elegantShoe.Id = value.Id;
                elegantShoe.CompanyName = value.CompanyName;
                elegantShoe.HasHeel = value.HasHeel;
                elegantShoe.HasInStock = value.HasInStock;
                elegantShoe.Price=value.Price;
                elegantShoe.Size=value.Size;
              await ShoeStoreDB.SaveChangesAsync();
                return Ok("item was update");
            }catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/ElegantShoe/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                ShoeStoreDB.ElegantShoes.Remove(await ShoeStoreDB.ElegantShoes.FindAsync(id));
                await ShoeStoreDB.SaveChangesAsync();
                return Ok("iream deleted");

            }catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
