using MongoDB.Driver;
using REST_SQL_New.Models;
using System.Collections.Generic;

namespace REST_NoSQL_New.Services
{
    public interface IMedalService
    {
        List<Medal> Get();
        Medal Get(string id);
        IMongoCollection<Medal> GetCollection();
    }
}
