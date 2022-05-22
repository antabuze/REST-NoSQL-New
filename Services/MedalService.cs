using REST_NoSQL_New.Data;
using REST_SQL_New.Models;
using System.Collections.Generic;
using MongoDB.Driver;

namespace REST_NoSQL_New.Services
{
    public class MedalService : IMedalService
    {
        private readonly IMongoCollection<Medal> _medals;

        public MedalService(IMedalStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _medals = database.GetCollection<Medal>(settings.CollectionName);
        }
        public List<Medal> Get()
        {
           return _medals.Find(medals => true).ToList();
        }

        public Medal Get(string id)
        {
            return _medals.Find(medal => medal.ID == id).FirstOrDefault();
        }
        public IMongoCollection<Medal> GetCollection()
        {
            return _medals;
        }
    }
}