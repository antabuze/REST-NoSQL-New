using Microsoft.AspNetCore.Mvc;
using REST_NoSQL_New.Services;
using REST_SQL_New.Models;
using System.Collections.Generic;


namespace REST_NoSQL_New.Controller
{
    [Route("api/athletes")]
    [ApiController]
    public class AthleteController : ControllerBase
    {
        private readonly IAthleteService athleteService;

        public AthleteController(IAthleteService athleteService)
        {
            this.athleteService = athleteService;
        }
        
        // GET: api/athletes
        [HttpGet]
        public ActionResult<List<Athlete>> Get()
        {
            return athleteService.Get();
        }

        // GET api/athletes/5
        [HttpGet("{id}")]
        public ActionResult<Athlete> Get(string id)
        {
            var athlete = athleteService.Get(id);

            if (athlete == null)
            {
                return NotFound($"Athlete with Id = {id} not found");
            }
            
            return athlete;
        }
    }
}
