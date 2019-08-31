using System;
using MyToDoList;
using MyToDoList.Configuration;
using MyToDoList.Tasks.Entities;
using MyToDoList.Tasks.Repositories;

namespace MyToDoListConsole
{
    class Program
    {
        private static readonly ITasksRepository _tasksRepository = new TaskRepository(new CloudClientsProvider(new StorageConfiguration()));

        static void Main(string[] args)
        {

            _tasksRepository.Insert(new TaskEntity
            {
                DueDate = DateTime.Today,
                Id = Guid.NewGuid(),
                Message = "mymsg",
                Title = "lol",
            });
            Console.WriteLine("Hello World!");
        }
    }
}
