using Microsoft.AspNetCore.Mvc;
using REST_NoSQL_New.Services;
using REST_SQL_New.Models;
using System.Collections.Generic;


namespace REST_NoSQL_New.Controller
{
    [Route("api/medals")]
    [ApiController]
    public class MedalController : ControllerBase
    {
        private readonly IMedalService medalService;

        public MedalController(IMedalService medalService)
        {
            this.medalService = medalService;
        }
        
        // GET: api/medals
        [HttpGet]
        public ActionResult<List<Medal>> Get()
        {
            return medalService.Get();
        }

        // GET api/medals/5
        [HttpGet("{id}")]
        public ActionResult<Medal> Get(string id)
        {
            var medal = medalService.Get(id);

            if (medal == null)
            {
                return NotFound($"Medal with Id = {id} not found");
            }
            
            return medal;
        }
    }
}
