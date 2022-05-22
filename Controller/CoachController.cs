using Microsoft.AspNetCore.Mvc;
using REST_NoSQL_New.Services;
using REST_SQL_New.Models;
using System.Collections.Generic;


namespace REST_NoSQL_New.Controller
{
    [Route("api/coaches")]
    [ApiController]
    public class CoachController : ControllerBase
    {
        private readonly ICoachService coachService;

        public CoachController(ICoachService coachService)
        {
            this.coachService = coachService;
        }
        
        // GET: api/coaches
        [HttpGet]
        public ActionResult<List<Coach>> Get()
        {
            return coachService.Get();
        }

        // GET api/coaches/5
        [HttpGet("{id}")]
        public ActionResult<Coach> Get(string id)
        {
            var coach = coachService.Get(id);

            if (coach == null)
            {
                return NotFound($"Coach with Id = {id} not found");
            }
            
            return coach;
        }
    }
}
