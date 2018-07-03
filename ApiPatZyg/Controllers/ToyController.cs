using ModelPatZyg;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiPatZyg.Controllers
{
    public class ToyController : ApiController
    {
        private readonly LiteRepository repository;

        public ToyController(LiteRepository repository)
        {
            this.repository = repository;
        }



        // GET api/values
        public IEnumerable<Toy> Get()
        {
            return repository.GetAll();
        }

        // GET api/values/5
        public Toy Get(int id)
        {
            return repository.Get(id);
        }

        // POST api/values
        public IHttpActionResult Post(Toy toy)
        {
            if (toy == null) {
                return BadRequest();
            }
            return Ok(repository.Add(toy));

        }

        // PUT api/values/5
        public void Put(Toy toy)
        {
            repository.Update(toy);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            Ok(repository.Delete(id));
        }
    }
}
