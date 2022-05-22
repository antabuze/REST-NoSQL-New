namespace REST_NoSQL_New.Data
{
    public class AthleteStoreDatabaseSettings : IAthleteStoreDatabaseSettings
    {
        public string CollectionName { get; set;}
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
