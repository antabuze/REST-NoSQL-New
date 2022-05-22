using Microsoft.AspNetCore.Mvc;
using REST_NoSQL_New.Services;
using REST_SQL_New.Models;
using System.Collections.Generic;


namespace REST_NoSQL_New.Controller
{
    [Route("api/medaltotals")]
    [ApiController]
    public class MedalTotalController : ControllerBase
    {
        private readonly IMedalTotalService medalTotalService;

        public MedalTotalController(IMedalTotalService medalTotalService)
        {
            this.medalTotalService = medalTotalService;
        }
        
        // GET: api/medaltotals
        [HttpGet]
        public ActionResult<List<MedalTotal>> Get()
        {
            return medalTotalService.Get();
        }

        // GET api/medaltotals/5
        [HttpGet("{id}")]
        public ActionResult<MedalTotal> Get(string id)
        {
            var medalTotal = medalTotalService.Get(id);

            if (medalTotal == null)
            {
                return NotFound($"Medal total with Id = {id} not found");
            }
            
            return medalTotal;
        }
    }
}
