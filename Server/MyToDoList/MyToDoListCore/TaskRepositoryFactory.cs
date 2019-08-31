using MyToDoList.Configuration;
using MyToDoList.Tasks.Repositories;

namespace MyToDoList
{
    public static class TaskRepositoryFactory
    {
        public static ITasksRepository Create()
        {
            return new TaskRepository(new CloudClientsProvider(new StorageConfiguration()));
        }
    }
}