using System.Collections.Generic;
using System.Threading.Tasks;
using MyToDoList.Tasks.Entities;

namespace MyToDoList.Tasks.Repositories
{
    public interface ITasksRepository
    {
        Task Insert(TaskEntity task);
        Task<List<TaskEntity>> GetAll(string uid);
        Task Delete(string uid, string taskId);
        TaskEntity Get(string uid, string taskId);
    }
}