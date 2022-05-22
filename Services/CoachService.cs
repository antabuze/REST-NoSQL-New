using REST_NoSQL_New.Data;
using REST_SQL_New.Models;
using System.Collections.Generic;
using MongoDB.Driver;

namespace REST_NoSQL_New.Services
{
    public class CoachService : ICoachService
    {
        private readonly IMongoCollection<Coach> _coaches;

        public CoachService(ICoachStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _coaches = database.GetCollection<Coach>(settings.CollectionName);
        }
        public List<Coach> Get()
        {
           return _coaches.Find(coach => true).ToList();
        }

        public Coach Get(string id)
        {
            return _coaches.Find(coach => coach.ID == id).FirstOrDefault();
        }
        public IMongoCollection<Coach> GetCollection()
        {
            return _coaches;
        }
    }
}