namespace REST_NoSQL_New.Data
{
    public class MedalStoreDatabaseSettings : IMedalStoreDatabaseSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
