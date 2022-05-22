namespace REST_NoSQL_New.Data
{
    public interface IAthleteStoreDatabaseSettings
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
