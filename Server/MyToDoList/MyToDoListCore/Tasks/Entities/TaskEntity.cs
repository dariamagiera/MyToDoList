using System;
using Microsoft.WindowsAzure.Storage.Table;

namespace MyToDoList.Tasks.Entities
{
    public class TaskEntity : TableEntity
    {
        public TaskEntity(string userId, Guid taskId)
        {
            base.PartitionKey = userId;
            base.RowKey = taskId.ToString();
        }

        public TaskEntity()
        {
        }

        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime DueDate { get; set; }
    }
}
