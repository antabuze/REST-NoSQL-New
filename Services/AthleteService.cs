using REST_NoSQL_New.Data;
using REST_SQL_New.Models;
using System.Collections.Generic;
using MongoDB.Driver;

namespace REST_NoSQL_New.Services
{
    public class AthleteService : IAthleteService
    {
        private readonly IMongoCollection<Athlete> _athletes;

        public AthleteService(IAthleteStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _athletes = database.GetCollection<Athlete>(settings.CollectionName);
        }
        public List<Athlete> Get()
        {
           return _athletes.Find(athlete => true).ToList();
        }

        public Athlete Get(string id)
        {
            return _athletes.Find(athlete => athlete.ID == id).FirstOrDefault();
        }

        public IMongoCollection<Athlete> GetCollection()
        {
            return _athletes;
        }
    }
}