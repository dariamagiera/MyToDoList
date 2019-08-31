using System;
using Microsoft.WindowsAzure.Storage.Table;

namespace MyToDoList.Tasks.Entities
{
    public class TaskEntity : TableEntity
    {
        public TaskEntity(string userId, string rowKey)
        {
            base.PartitionKey = userId;
            base.RowKey = rowKey;
        }

        public TaskEntity()
        {
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime DueDate { get; set; }
    }
}
