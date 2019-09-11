using MyToDoList.Configuration;
using MyToDoList.Tasks.Repositories;

namespace MyToDoList.Tasks
{
    public static class TaskRepositoryFactory
    {
        private static ITasksRepository _repository;

        public static ITasksRepository Create()
        {
            return _repository ??
                   (_repository = new TaskRepository(new CloudClientsProvider(new StorageConfiguration())));
        }
    }
}