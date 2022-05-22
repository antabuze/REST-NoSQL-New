using MongoDB.Driver;
using REST_SQL_New.Models;
using System.Collections.Generic;

namespace REST_NoSQL_New.Services
{
    public interface IAthleteService
    {
        List<Athlete> Get();
        Athlete Get(string id);
        IMongoCollection<Athlete> GetCollection();
        
    }
}
