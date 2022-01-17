using ShoeStore.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoeStore.Controllers.api
{
    public class SportShoeController : ApiController
    {
     static   string stringConnecstion = "Data Source=.;Initial Catalog=ShoesStore;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;Application Name=EntityFramework";

        // GET: api/SportShoe
        public IHttpActionResult Get()
        {
            try
            {
               List<SportShoe>elegantShoesList=new List<SportShoe>();
                using (SqlConnection connection = new SqlConnection(stringConnecstion))
                {
                  connection.Open();
                    string query = "SELECT * FROM SportShoe";
                    SqlCommand command=new SqlCommand(query, connection);
                   SqlDataReader reader= command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            elegantShoesList.Add(new SportShoe(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4)));

                        }
                       
                        return Ok(new { elegantShoesList });
                    }
                    connection.Close();
                    return Ok(new { elegantShoesList });
                }
            }
            catch (SqlException ex)
            {
                return Ok(new { ex.Message });

            }
            catch(Exception ex)
            {
                return Ok(new { ex.Message });
            }


        }

        // GET: api/SportShoe/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnecstion))
                {
                    connection.Open();
                    string query = $@"SELECT * FROM WHERE Id={id}";
                    SqlCommand command=new SqlCommand(query,connection);
                    SqlDataReader reader=command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            SportShoe sportShoe=new SportShoe(reader.GetInt32(0),reader.GetString(1),reader.GetString(2),reader.GetInt32(3),reader.GetInt32(4));
                            return Ok(new { sportShoe });
                        }
                       
                    }
                    connection.Close();
                    return Ok(new { Message = "not found" });
                }

            }catch(SqlException ex)
            {
                return Ok(new { ex.Message });

            }
            catch (Exception ex)
            {
                return Ok(new { ex.Message });
            }

        }

        // POST: api/SportShoe
        public IHttpActionResult Post([FromBody]SportShoe value)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(stringConnecstion))
                {
                    connection.Open();
                    string query = $@"INSERT INTO SportShoe (CompanyName,ModelName,Size,Price) VALUES('{value.CompanyName}','{value.ModelName}',{value.Size},{value.Price} )";
                    SqlCommand command=new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    return Ok(Ok(new { message = "item was update" }));

                }

            }catch(SqlException ex)
            {
                return Ok(new { ex.Message });

            }
            catch (Exception ex)
            {
                return Ok(new { ex.Message });
            }
        }

        // PUT: api/SportShoe/5
        public void Put(int id, [FromBody] SportShoe value)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(stringConnecstion))
                {
                    connection.Open();
                    string query=$@"UPDATE SportShoe SET SET CompanyName='{value.CompanyName}', "
                }

            }catch(SqlException ex)
            {

            }catch (Exception ex)
            {

            }

        }

        // DELETE: api/SportShoe/5
        public void Delete(int id)
        {
        }
    }
}
