using MongoDB.Driver;
using REST_SQL_New.Models;
using System.Collections.Generic;

namespace REST_NoSQL_New.Services
{
    public interface ICoachService
    {
        List<Coach> Get();
        Coach Get(string id);
        IMongoCollection<Coach> GetCollection();
    }
}
