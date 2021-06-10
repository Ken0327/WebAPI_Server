using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Server.Models;

namespace WebAPI_Server.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
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

        [Route("CurrentTime")]
        [HttpGet]
        public string GetCurrentTime()
        {
            return DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

        [Route("api/TestAACleanroom")]
        [HttpPost]
        public JsonResponse InsertInformalCleanroom([FromBody] CleanroomAAData input)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return ApiTool.Result(false, $"Invalid Input=>{Newtonsoft.Json.JsonConvert.SerializeObject(ModelState)}");
                }

                string json = JsonConvert.SerializeObject(input);
                return ApiTool.Result(true, "Receive data.", json);
            }
            catch (Exception e)
            {
                //_logger.Trace($"Insert TblCleanroom fail:{e}");
                return ApiTool.Result(false, e.ToString());
            }
        }
    }
}
