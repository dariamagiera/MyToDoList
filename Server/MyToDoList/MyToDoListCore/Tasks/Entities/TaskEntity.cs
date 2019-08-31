using System;
using Microsoft.WindowsAzure.Storage.Table;

namespace MyToDoList.Tasks.Entities
{
    public class TaskEntity : TableEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime DueDate { get; set; }
    }
}
