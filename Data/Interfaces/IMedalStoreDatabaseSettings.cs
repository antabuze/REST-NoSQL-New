namespace REST_NoSQL_New.Data
{
    public interface IMedalStoreDatabaseSettings
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
