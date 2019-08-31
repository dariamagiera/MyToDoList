using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Table;
using MyToDoList.Configuration;

namespace MyToDoList
{
    public class CloudClientsProvider : ICloudClientsProvider
    {
        private const bool _USE_HTTPS = true;
        private readonly IStorageConfiguration _configuration;

        public CloudClientsProvider(IStorageConfiguration configuration)
        {
            _configuration = configuration;
        }

        public CloudStorageAccount GetCloudStorageAccount()
        {
            return new CloudStorageAccount( new StorageCredentials(
                    _configuration.AccountName, _configuration.AccountKey), _USE_HTTPS);
        }

        public CloudTableClient GetCloudTableClient()
        {
           return GetCloudStorageAccount().CreateCloudTableClient();
        }
    }
}