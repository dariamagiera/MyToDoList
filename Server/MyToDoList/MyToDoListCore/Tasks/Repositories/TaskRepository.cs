using System.Collections.Generic;
using System.Linq;
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
            await _tasksTable.ExecuteAsync(insertOperation);
        }

        public async Task<List<TaskEntity>> GetAll(string uid)
        {
            var query = new TableQuery<TaskEntity>();
            var result = await _tasksTable.ExecuteQuerySegmentedAsync(query, new TableContinuationToken());
            return result.Results.Where(x => x.PartitionKey == uid).ToList();
        }

        public async Task Delete(string uid, string taskId)
        {
            ITableEntity entity = new TableEntity(uid, taskId);
            entity.ETag = "*";
            var deleteOperation = TableOperation.Delete(entity);
            await _tasksTable.ExecuteAsync(deleteOperation);
        }

        public TaskEntity Get(string uid, string taskId)
        {
            var retrieveOperation = TableOperation.Retrieve(uid, taskId);
            return (TaskEntity) _tasksTable.ExecuteAsync(retrieveOperation).Result.Result;
        }
    }
}