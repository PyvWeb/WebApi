using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BsWebpub;
using BsWebpub.Entity;

namespace WebApi.Controllers.WebPub
{
    [Route("api/webpub/[controller]")]
    [ApiController]
    public class Pub_FactController : ControllerBase
    {
        // GET api/values
        Repository<pub_fact> repository;

        [HttpGet]
        public ActionResult<IEnumerable<pub_fact>> Get()
        {
            using (var dataContext = new WebpubContext())
            {
                repository = new Repository<pub_fact>(dataContext);
                var facts  = repository.GetAll().Where(x => x.out_date.StartsWith("9999"));

                return facts.ToList();

                
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
