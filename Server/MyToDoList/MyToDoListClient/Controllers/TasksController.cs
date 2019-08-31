using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyToDoList;
using MyToDoList.Configuration;
using MyToDoList.Tasks.Entities;
using MyToDoList.Tasks.Repositories;

namespace MyToDoListClient.Controllers
{
    [Route("api/task")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITasksRepository _tasksRepository = new TaskRepository(new CloudClientsProvider(new StorageConfiguration()));

        // GET: api/Tasks
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1a", "value2" };
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

        [HttpPut()]
        public void Put([FromBody] string value)
        {
            _tasksRepository.Insert(new TaskEntity
            {
                DueDate = DateTime.Today,
                Id = Guid.NewGuid(),
                Message = "mymsg",
                Title = "lol",
            });
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
