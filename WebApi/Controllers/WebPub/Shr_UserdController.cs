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
    public class Shr_UserdController : ControllerBase
    {
        // GET api/values
        Repository<shr_userd> repository;

        [HttpGet]
        public ActionResult<IEnumerable<shr_userd>> Get()
        {
            using (var dataContext = new WebpubContext())
            {
                repository = new Repository<shr_userd>(dataContext);
                var users  = repository.GetAll().Where(x => x.end_mk.Equals("N"));

                return users.ToList();
            }
        }

        // GET api/values/5
        [HttpGet("{user_id}")]
        public ActionResult<shr_userd> Get(decimal user_id)
        {
            using (var dataContext = new WebpubContext())
            {
                repository = new Repository<shr_userd>(dataContext);
                var user = repository.GetById(user_id);

                
                return user;
            }

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
