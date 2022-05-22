using MongoDB.Driver;
using REST_SQL_New.Models;
using System.Collections.Generic;

namespace REST_NoSQL_New.Services
{
    public interface IMedalTotalService
    {
        List<MedalTotal> Get();
        MedalTotal Get(string id);
        IMongoCollection<MedalTotal> GetCollection();
    }
}
