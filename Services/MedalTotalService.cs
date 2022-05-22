using REST_NoSQL_New.Data;
using REST_SQL_New.Models;
using System.Collections.Generic;
using MongoDB.Driver;

namespace REST_NoSQL_New.Services
{
    public class MedalTotalService : IMedalTotalService
    {
        private readonly IMongoCollection<MedalTotal> _medalTotals;

        public MedalTotalService(IMedalTotalStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _medalTotals = database.GetCollection<MedalTotal>(settings.CollectionName);
        }
        public List<MedalTotal> Get()
        {
           return _medalTotals.Find(medalTotals => true).ToList();
        }

        public MedalTotal Get(string id)
        {
            return _medalTotals.Find(medalTotal => medalTotal.ID == id).FirstOrDefault();
        }
        public IMongoCollection<MedalTotal> GetCollection()
        {
            return _medalTotals;
        }
    }
}