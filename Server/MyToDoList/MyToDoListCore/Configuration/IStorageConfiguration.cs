namespace MyToDoList.Configuration
{
    public interface IStorageConfiguration
    {
        string AccountName { get; }
        string AccountKey { get; }
    }
}