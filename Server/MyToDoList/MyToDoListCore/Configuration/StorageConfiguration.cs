namespace MyToDoList.Configuration
{
    public class StorageConfiguration : IStorageConfiguration
    {
        public string AccountName => "mytodolistdev";

        public string AccountKey =>
            "fake";
    }
}