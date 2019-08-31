using System.Threading.Tasks;
using MyToDoList.Tasks.Entities;

namespace MyToDoList.Tasks.Repositories
{
    public interface ITasksRepository
    {
        Task Insert(TaskEntity task);
    }
}