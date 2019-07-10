using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        // GET: api/persons  
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return new List<Person>
        {
            new Person{Id = 1 , Name = "catcher wong"},
            new Person{Id = 2 , Name = "james"}
        };
        }

        // GET api/persons/5  
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return new Person { Id = id, Name = "name" };
        }

        // POST api/persons  
        [HttpPost]
        public Person Post([FromBody]Person person)
        {
            if (person == null) return new Person();

            return new Person { Id = person.Id, Name = person.Name };
        }

        // PUT api/persons/  
        [HttpPut]
        public string Put([FromBody]int id)
        {
            return $"put {id}";
        }

        // DELETE api/persons/5  
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"del {id}";
        }
    }
}