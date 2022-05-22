using HotChocolate;
using HotChocolate.Data;
using MongoDB.Driver;
using REST_NoSQL_New.Services;
using REST_SQL_New.Models;

namespace REST_NoSQL_New.Data
{
    public class Query
    {
        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public IExecutable<Athlete> GetAthletes([Service] IAthleteService service)
        {
            return service.GetCollection().AsExecutable(); // THIS WORKS!
        }


        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public IExecutable<Coach> GetCoaches([Service] ICoachService service) 
        {
            return service.GetCollection().AsExecutable();
        }

        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public IExecutable<Medal> GetMedals([Service] IMedalService service)
        {
            return service.GetCollection().AsExecutable();
        }

        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public IExecutable<MedalTotal> GetMedalTotals([Service] IMedalTotalService service)
        {
            return service.GetCollection().AsExecutable();
        }
    }
}
