using System;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;
using MyToDoList.Tasks.Entities;

namespace MyToDoList.Tasks.Repositories
{
    internal class TaskRepository : ITasksRepository
    {
        private const string _TABLE_NAME = "tasksTable";

        private readonly ICloudClientsProvider _accountProvider;
        private readonly CloudTable _tasksTable;

        public TaskRepository(ICloudClientsProvider accountProvider)
        {
            _accountProvider = accountProvider;
            var tableClient = _accountProvider.GetCloudTableClient();

            _tasksTable = tableClient.GetTableReference(_TABLE_NAME);
            _tasksTable.CreateIfNotExistsAsync();
        }

        public async Task Insert(TaskEntity task)
        {
            var insertOperation = TableOperation.Insert(task);
            var result = await _tasksTable.ExecuteAsync(insertOperation).ConfigureAwait(false);
        }
    }
}