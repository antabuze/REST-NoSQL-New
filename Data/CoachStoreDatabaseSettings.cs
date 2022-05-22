namespace REST_NoSQL_New.Data
{
    public class CoachStoreDatabaseSettings : ICoachStoreDatabaseSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
