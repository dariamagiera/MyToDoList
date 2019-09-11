using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyToDoList.Tasks;
using MyToDoList.Tasks.Entities;
using MyToDoList.Tasks.Repositories;

namespace MyToDoListClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITasksRepository _tasksRepository = TaskRepositoryFactory.Create();

        [HttpGet]
        public async Task<IEnumerable<TaskEntity>> Get([FromBody] string uid)
        {
            return await _tasksRepository.GetAll(uid);
        }

        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPut]
        public void Put([FromBody] TaskEntity task)
        {
            _tasksRepository.Insert(task);
        }

        [HttpDelete("{uid}/{taskId}")]
        public void Delete(string uid, string taskId)
        {
            _tasksRepository.Delete(uid, taskId);
        }
    }
}
