 using System;
using System.Collections.Generic;
using System.Linq;
 using System.Net;
 using System.Net.Http;
 using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyToDoListClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        // GET: api/Tasks
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Tasks/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tasks
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Tasks/5
        [HttpPut]
        HttpResponseMessage Put()
        {
            return new HttpResponseMessage(HttpStatusCode.Accepted);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
