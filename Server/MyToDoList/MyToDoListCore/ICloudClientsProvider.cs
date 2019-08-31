using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace MyToDoList
{
    public interface ICloudClientsProvider
    {
        CloudStorageAccount GetCloudStorageAccount();
        CloudTableClient GetCloudTableClient();
    }
}