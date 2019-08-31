using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace MyToDoList
{
    internal interface ICloudClientsProvider
    {
        CloudStorageAccount GetCloudStorageAccount();
        CloudTableClient GetCloudTableClient();
    }
}